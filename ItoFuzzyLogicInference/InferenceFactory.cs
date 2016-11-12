using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using InferenceLibrary;
using InferenceLibrary.Rules;

namespace ItoFuzzyLogicInference
{
    public class InferenceFactory
    {
        public class LinguisticVariableNotPresentException : Exception { }
        public class InvalidLinguisticVariableId : ArgumentException
        {
            public InvalidLinguisticVariableId(string message) : base(message)
            {
            }
        }
        public class InvalidMembershipFunctionId : ArgumentException { }

        private readonly XDocument _xmlDocument;

        public IEnumerable<LinguisticVariable> LinguisticVariables { get; private set; }
        public IEnumerable<FuzzyRule> FuzzyRules { get; private set; }

        public InferenceFactory(string fileName)
        {
            _xmlDocument = XDocument.Load(fileName);
        }

        public void LoadData()
        {
            LinguisticVariables = BuildLinguisticVariables();
            FuzzyRules = BuildFuzzyRules();
        }

        private IEnumerable<LinguisticVariable> BuildLinguisticVariables()
        {

            var variableNodes = _xmlDocument.Descendants("LinguisticVariable");
            return variableNodes.Select(variableNode => new LinguisticVariable(variableNode.Attribute("id")?.Value, variableNode.Attribute("display_name")?.Value, variableNode.Attribute("display_unit")?.Value)
            {
                MembershipFunctions = BuildMembershipFunctions(variableNode)
            }).ToList();
        }

        private IEnumerable<MembershipFunction> BuildMembershipFunctions(XElement variableElement)
        {
            return variableElement.Descendants("MembershipFunction").Select(BuildMembershipFunction).ToList();
        }

        private MembershipFunction BuildMembershipFunction(XElement functionElement)
        {
            return new MembershipFunction(
                functionElement.Attribute("id")?.Value, 
                functionElement.Attribute("display_name")?.Value,
                double.Parse(functionElement.Attribute("x1")?.Value), 
                double.Parse(functionElement.Attribute("x2")?.Value),
                double.Parse(functionElement.Attribute("x3")?.Value),
                double.Parse(functionElement.Attribute("x4")?.Value));
        }

        private IEnumerable<FuzzyRule> BuildFuzzyRules()
        {
            return _xmlDocument.Descendants("FuzzyRule").Select(BuildFuzzyRule).ToList();
        }

        private FuzzyRule BuildFuzzyRule(XElement ruleElement)
        {
            var conditions = ruleElement.Descendants("Condition").Select(BuildCondition).ToList();
            var conclusion = ruleElement.Descendants("Conclusion").Select(BuildConclusion).ToList()[0];

            return new FuzzyRule(conditions, conclusion);
        }

        private FuzzyCondition BuildCondition(XElement conditionElement)
        {

            var linguisticVariableId = conditionElement.Attribute("linguistic_variable_id")?.Value;
            var membershipFunctionId = conditionElement.Attribute("membership_function_id")?.Value;

            return new FuzzyCondition(FindMembershipFunction(linguisticVariableId, membershipFunctionId));
        }

        private FuzzyConclusion BuildConclusion(XElement conclusionElement)
        {

            var linguisticVariableId = conclusionElement.Attribute("linguistic_variable_id")?.Value;
            var membershipFunctionId = conclusionElement.Attribute("membership_function_id")?.Value;

            return new FuzzyConclusion(FindMembershipFunction(linguisticVariableId, membershipFunctionId));
        }

        private MembershipFunction FindMembershipFunction(string linguisticVariableId, string membershipFunctionId)
        {
            var linguisticVariable = LinguisticVariables.First(v => v.Id == linguisticVariableId);

            if (linguisticVariable == null)
            {
                throw new InvalidLinguisticVariableId("Invalid linguistic_variable_id: " + linguisticVariableId);
            }

            var membershipFunction = linguisticVariable.MembershipFunctions.First(f => f.Id == membershipFunctionId);

            if (membershipFunction == null)
            {
                throw new InvalidLinguisticVariableId("Invalid membership_function_id: " + membershipFunctionId);
            }

            return membershipFunction;
        }
    }
}

using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ItoFuzzyLogicInference.Tests
{
    [TestClass]
    public class InferenceFactoryTest
    {
        [TestMethod]
        public void XmlLoadIntegrationTest()
        {
            var factory = new InferenceFactory("Fixtures/simple_inference.xml");
            var inference = factory.BuildInference();
            Assert.AreEqual(2, inference.Rules.Count());
            Assert.AreEqual(2, factory.LinguisticVariables.Count());
            Assert.AreSame(inference.Rules.First().Conditions.First().MembershipFunction.LinguisticVariable, factory.LinguisticVariables.First());
        }
    }
}

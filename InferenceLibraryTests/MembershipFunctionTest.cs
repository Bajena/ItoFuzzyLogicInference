using System;
using InferenceLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InferenceLibraryTests
{
    [TestClass]
    public class MembershipFunctionTest
    {
        [TestMethod]
        public void FuzzifyTest()
        {
            var membershipFunction = new MembershipFunction("old", "Old", 30, 50, 50, 70);

            Assert.AreEqual(0, membershipFunction.Fuzzify(0));
            Assert.AreEqual(0, membershipFunction.Fuzzify(100));
            Assert.AreEqual(0.5, membershipFunction.Fuzzify(40));
            Assert.AreEqual(0.5, membershipFunction.Fuzzify(60));
            Assert.AreEqual(1, membershipFunction.Fuzzify(50));
        }
    }
}

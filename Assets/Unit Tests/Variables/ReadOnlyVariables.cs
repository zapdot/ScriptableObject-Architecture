using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace ScriptableObjectArchitecture.Tests
{
    [TestFixture]
    internal sealed class ReadOnlyVariables
    {
        [Test]
        public void AssertThatReadOnlyVariableCannotBeModified()
        {
            var variable = ScriptableObject.CreateInstance<FloatVariable>();
            variable.Value = 5f;
            variable.ReadOnly = true;

            variable.Value = 10f;

            Assert.AreEqual(5, variable.Value);
        }
    }
}
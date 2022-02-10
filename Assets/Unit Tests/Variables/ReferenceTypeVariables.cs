using NUnit.Framework;
using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture.Tests
{
    [TestFixture]
    internal sealed class ReferenceTypeVariables
    {
        private sealed class Foo { }

        private sealed class MockRefVariable : BaseVariable<Foo> { }
        private sealed class MockRefVariableWithEvent : BaseVariable<Foo, UnityEvent<Foo>> { }

        /// <summary>
        /// Ensure ref-type variables can be set to null without causing errors.
        /// </summary>
        [Test]
        public void CanSetReferenceTypeVariableValueToNull()
        {
            var foo = new Foo();
            var refVariable = (MockRefVariable)ScriptableObject.CreateInstance(typeof(MockRefVariable));
            refVariable.Value = foo;

            Assert.AreEqual(foo, refVariable.Value);

            refVariable.Value = null;

            Assert.IsNull(refVariable.Value);
        }

        /// <summary>
        /// Ensure ref-type variables with events can be set to null without causing errors.
        /// </summary>
        [Test]
        public void CanSetReferenceTypeVariableWithEventValueToNull()
        {
            var foo = new Foo();
            var refVariable = (MockRefVariableWithEvent)ScriptableObject.CreateInstance(typeof(MockRefVariableWithEvent));
            refVariable.Value = foo;

            Assert.AreEqual(foo, refVariable.Value);

            refVariable.Value = null;

            Assert.IsNull(refVariable.Value);
        }
    }
}

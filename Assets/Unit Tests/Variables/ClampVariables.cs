using NUnit.Framework;
using UnityEngine;
// ReSharper disable CheckNamespace

namespace ScriptableObjectArchitecture.Tests
{
    [TestFixture]
    internal sealed class ClampVariables
    {
        [Test]
        public void AssertThatFloatVariablesClampValues()
        {
            const float MIN = 0f;
            const float MAX = 5f;

            var variable = ScriptableObject.CreateInstance<FloatVariable>();
            variable.IsClamped = true;
            variable.MinClampValue = MIN;
            variable.MaxClampValue = MAX;

            // Value can be set within range
            variable.Value = 1f;

            Assert.AreEqual(1f, variable.Value);

            // Value wll be clamped past greater extents of range
            variable.Value = 10f;

            Assert.AreEqual(MAX, variable.Value);

            // Value wll be clamped past lower extents of range
            variable.Value = -10f;

            Assert.AreEqual(MIN, variable.Value);
        }

        [Test]
        public void AssertThatDoubleVariablesClampValues()
        {
            const double MIN = 0d;
            const double MAX = 5d;

            var variable = ScriptableObject.CreateInstance<DoubleVariable>();
            variable.IsClamped = true;
            variable.MinClampValue = MIN;
            variable.MaxClampValue = MAX;

            // Value can be set within range
            variable.Value = 1d;

            Assert.AreEqual(1d, variable.Value);

            // Value wll be clamped past greater extents of range
            variable.Value = 10d;

            Assert.AreEqual(MAX, variable.Value);

            // Value wll be clamped past lower extents of range
            variable.Value = -10d;

            Assert.AreEqual(MIN, variable.Value);
        }

        [Test]
        public void AssertThatIntVariablesClampValues()
        {
            const int MIN = 0;
            const int MAX = 5;

            var variable = ScriptableObject.CreateInstance<IntVariable>();
            variable.IsClamped = true;
            variable.MinClampValue = MIN;
            variable.MaxClampValue = MAX;

            // Value can be set within range
            variable.Value = 1;

            Assert.AreEqual(1, variable.Value);

            // Value wll be clamped past greater extents of range
            variable.Value = 10;

            Assert.AreEqual(MAX, variable.Value);

            // Value wll be clamped past lower extents of range
            variable.Value = -10;

            Assert.AreEqual(MIN, variable.Value);
        }

        [Test]
        public void AssertThatLongVariablesClampValues()
        {
            const long MIN = 0;
            const long MAX = 5;

            var variable = ScriptableObject.CreateInstance<LongVariable>();
            variable.IsClamped = true;
            variable.MinClampValue = MIN;
            variable.MaxClampValue = MAX;

            // Value can be set within range
            variable.Value = 1;

            Assert.AreEqual(1, variable.Value);

            // Value wll be clamped past greater extents of range
            variable.Value = 10;

            Assert.AreEqual(MAX, variable.Value);

            // Value wll be clamped past lower extents of range
            variable.Value = -10;

            Assert.AreEqual(MIN, variable.Value);
        }

        [Test]
        public void AssertThatShortVariablesClampValues()
        {
            const short MIN = 0;
            const short MAX = 5;

            var variable = ScriptableObject.CreateInstance<ShortVariable>();
            variable.IsClamped = true;
            variable.MinClampValue = MIN;
            variable.MaxClampValue = MAX;

            // Value can be set within range
            variable.Value = 1;

            Assert.AreEqual(1, variable.Value);

            // Value wll be clamped past greater extents of range
            variable.Value = 10;

            Assert.AreEqual(MAX, variable.Value);

            // Value wll be clamped past lower extents of range
            variable.Value = -10;

            Assert.AreEqual(MIN, variable.Value);
        }

        [Test]
        public void AssertThatUintVariablesClampValues()
        {
            const uint MIN = 5;
            const uint MAX = 10;

            var variable = ScriptableObject.CreateInstance<UIntVariable>();
            variable.IsClamped = true;
            variable.MinClampValue = MIN;
            variable.MaxClampValue = MAX;

            // Value can be set within range
            variable.Value = 6;

            Assert.AreEqual(6, variable.Value);

            // Value wll be clamped past greater extents of range
            variable.Value = 15;

            Assert.AreEqual(MAX, variable.Value);

            // Value wll be clamped past lower extents of range
            variable.Value = 0;

            Assert.AreEqual(MIN, variable.Value);
        }

        [Test]
        public void AssertThatULongVariablesClampValues()
        {
            const ulong MIN = 5;
            const ulong MAX = 10;

            var variable = ScriptableObject.CreateInstance<ULongVariable>();
            variable.IsClamped = true;
            variable.MinClampValue = MIN;
            variable.MaxClampValue = MAX;

            // Value can be set within range
            variable.Value = 6;

            Assert.AreEqual(6, variable.Value);

            // Value wll be clamped past greater extents of range
            variable.Value = 15;

            Assert.AreEqual(MAX, variable.Value);

            // Value wll be clamped past lower extents of range
            variable.Value = 0;

            Assert.AreEqual(MIN, variable.Value);
        }

        [Test]
        public void AssertThatUShortVariablesClampValues()
        {
            const ushort MIN = 5;
            const ushort MAX = 10;

            var variable = ScriptableObject.CreateInstance<UShortVariable>();
            variable.IsClamped = true;
            variable.MinClampValue = MIN;
            variable.MaxClampValue = MAX;

            // Value can be set within range
            variable.Value = 6;

            Assert.AreEqual(6, variable.Value);

            // Value wll be clamped past greater extents of range
            variable.Value = 15;

            Assert.AreEqual(MAX, variable.Value);

            // Value wll be clamped past lower extents of range
            variable.Value = 0;

            Assert.AreEqual(MIN, variable.Value);
        }

        [Test]
        public void AssertThatByteVariablesClampValues()
        {
            const byte MIN = 5;
            const byte MAX = 10;

            var variable = ScriptableObject.CreateInstance<ByteVariable>();
            variable.IsClamped = true;
            variable.MinClampValue = MIN;
            variable.MaxClampValue = MAX;

            // Value can be set within range
            variable.Value = 6;

            Assert.AreEqual(6, variable.Value);

            // Value wll be clamped past greater extents of range
            variable.Value = 15;

            Assert.AreEqual(MAX, variable.Value);

            // Value wll be clamped past lower extents of range
            variable.Value = 0;

            Assert.AreEqual(MIN, variable.Value);
        }

        [Test]
        public void AssertThatSByteVariablesClampValues()
        {
            const sbyte MIN = 5;
            const sbyte MAX = 10;

            var variable = ScriptableObject.CreateInstance<SByteVariable>();
            variable.IsClamped = true;
            variable.MinClampValue = MIN;
            variable.MaxClampValue = MAX;

            // Value can be set within range
            variable.Value = 6;

            Assert.AreEqual(6, variable.Value);

            // Value wll be clamped past greater extents of range
            variable.Value = 15;

            Assert.AreEqual(MAX, variable.Value);

            // Value wll be clamped past lower extents of range
            variable.Value = 0;

            Assert.AreEqual(MIN, variable.Value);
        }
    }
}

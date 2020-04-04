using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;

namespace ScriptableObjectArchitecture.Editor
{
    /// <summary>
    /// A helper class for drawing better controls for clamped value types (mostly simple C# types)
    /// </summary>
    public static class ClampValueHelper
    {
        private static readonly List<Type> SUPPORTED_INT_TYPES;
        private static readonly List<Type> SUPPORTED_FLOAT_TYPES;

        static ClampValueHelper()
        {
            SUPPORTED_INT_TYPES = new List<Type>
            {
                typeof(sbyte),
                typeof(byte),
                typeof(short),
                typeof(ushort),
                typeof(int)
            };

            SUPPORTED_FLOAT_TYPES = new List<Type>
            {
                typeof(float)
            };
        }

        /// <summary>
        ///  Draws a slider for the passed <see cref="SerializedProperty"/> values.
        /// </summary>
        /// <param name="valueProp"></param>
        /// <param name="minProp"></param>
        /// <param name="maxProp"></param>
        public static void DrawClampRangeLayout(
            SerializedProperty valueProp,
            SerializedProperty minProp,
            SerializedProperty maxProp)
        {
            var valueType = GetType(valueProp);

            if (SUPPORTED_INT_TYPES.Contains(valueType))
            {
                EditorGUILayout.IntSlider(valueProp, minProp.intValue, maxProp.intValue);
            }
            else if (SUPPORTED_FLOAT_TYPES.Contains(valueType))
            {
                EditorGUILayout.Slider(valueProp, minProp.floatValue, maxProp.floatValue);
            }
        }

        /// <summary>
        /// Returns true if the passed <paramref name="valueProp"/> can be drawn with better clamp controls.
        /// </summary>
        /// <param name="valueProp"></param>
        /// <returns></returns>
        public static bool CanDrawClampRange(SerializedProperty valueProp)
        {
            var valueType = GetType(valueProp);

            return CanDrawClampRange(valueType);
        }

        /// <summary>
        /// Returns true if the passed <paramref name="valueType"/> can be drawn with better clamp controls.
        /// </summary>
        /// <param name="valueType"></param>
        /// <returns></returns>
        public static bool CanDrawClampRange(Type valueType)
        {
            return valueType != null &&
                   SUPPORTED_INT_TYPES.Contains(valueType) ||
                   SUPPORTED_FLOAT_TYPES.Contains(valueType);
        }

        /// <summary>
        /// Attempts to get the true type of the <see cref="SerializedProperty"/> on its object. This purposefully doesn't care about
        /// attempting to resolve <see cref="SerializedProperty"/> of array or value types as its usage in this class
        /// should always be constrained to a single value type and if it doesn't its not relevant for this class.
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        private static Type GetType(SerializedProperty property)
        {
            var containingObjectType = property.serializedObject.targetObject.GetType();
            var fi = containingObjectType.GetField(property.propertyPath, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            return fi == null ? null : fi.FieldType;
        }
    }
}
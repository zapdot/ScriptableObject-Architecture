using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [System.Serializable]
    public sealed class ObjectReference : BaseReference<Object, ObjectVariable>
    {
        public ObjectReference() : base() { }
        public ObjectReference(Object value) : base(value) { }
    }
}
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
    public abstract class BaseVariable : GameEventBase
    {
        public abstract bool IsClamped { get; internal set; }
        public abstract bool Clampable { get; }
        public abstract bool ReadOnly { get; internal set; }
        public abstract System.Type Type { get; }
        public abstract object BaseValue { get; set; }
    }
    public abstract class BaseVariable<T> : BaseVariable
    {
        public virtual T Value
        {
            get
            {
                return _value;
            }
            set
            {
                // If the value was changed as a result of calling SetValue, raise the event.
                if (SetValue(value))
                {
                    Raise();
                }
            }
        }
        public virtual T MinClampValue
        {
            get
            {
                if(Clampable)
                {
                    return _minClampedValue;
                }
                else
                {
                    return default(T);
                }
            }
            internal set { _minClampedValue = value; }
        }
        public virtual T MaxClampValue
        {
            get
            {
                if(Clampable)
                {
                    return _maxClampedValue;
                }
                else
                {
                    return default(T);
                }
            }
            internal set { _maxClampedValue = value; }
        }

        public override bool Clampable { get { return false; } }

        public override bool ReadOnly
        {
            get { return _readOnly; }
            internal set { _readOnly = value; }
        }

        public override bool IsClamped
        {
            get { return _isClamped; }
            internal set { _isClamped = value; }
        }

        public override System.Type Type { get { return typeof(T); } }
        public override object BaseValue
        {
            get
            {
                return _value;
            }
            set
            {
                SetValue((T)value);
                Raise();
            }
        }

        [SerializeField]
        protected T _value = default(T);
        [SerializeField]
        private bool _readOnly = false;
        [SerializeField]
        private bool _raiseWarning = true;
        [SerializeField]
        protected bool _isClamped = false;
        [SerializeField]
        protected T _minClampedValue = default(T);
        [SerializeField]
        protected T _maxClampedValue = default(T);

        protected virtual bool SetValue(BaseVariable<T> value)
        {
            return SetValue(value.Value);
        }

        protected virtual bool SetValue(T value)
        {
            var didValueChange = false;
            T newValue = value;

            if (_readOnly)
            {
                RaiseReadonlyWarning();
                newValue = _value;
            }
            else if(Clampable && IsClamped)
            {
                newValue = ClampValue(value);
            }

            if (!EqualityComparer<T>.Default.Equals(_value, newValue))
            {
                didValueChange = true;
                _value = newValue;
            }

            return didValueChange;
        }
        protected virtual T ClampValue(T value)
        {
            return value;
        }
        private void RaiseReadonlyWarning()
        {
            if (!_readOnly || !_raiseWarning)
                return;

            Debug.LogWarning("Tried to set value on " + name + ", but value is readonly!", this);
        }
        public override string ToString()
        {
            return _value == null ? "null" : _value.ToString();
        }
        public static implicit operator T(BaseVariable<T> variable)
        {
            return variable.Value;
        }
    }
    public abstract class BaseVariable<T, TEvent> : BaseVariable<T> where TEvent : UnityEvent<T>
    {
        [SerializeField]
        private TEvent _event = default(TEvent);

        protected override bool SetValue(T value)
        {
            var result = false;
            T oldValue = _value;

            base.SetValue(value);

            T newValue = _value;

            if (!EqualityComparer<T>.Default.Equals(oldValue, newValue))
            {
                result = true;

                if (_event != null)
                {
                    _event.Invoke(newValue);
                }
            }

            return result;
        }
        public void AddListener(UnityAction<T> callback)
        {
            _event.AddListener(callback);
        }
        public void RemoveListener(UnityAction<T> callback)
        {
            _event.RemoveListener(callback);
        }
        public override void RemoveAll()
        {
            base.RemoveAll();
            _event.RemoveAllListeners();
        }
    }
}

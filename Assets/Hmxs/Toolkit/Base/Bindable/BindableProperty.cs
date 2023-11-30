using System;

namespace Hmxs.Toolkit.Base.Bindable
{
    public struct BindableProperty<T> where T : IEquatable<T>
    {
        private T _value;

        public T Value
        {
            get => _value;
            set
            {
                if(_value.Equals(value)) return;
                _value = value;
                OnValueChanged?.Invoke(_value);
            }
        }

        public Action<T> OnValueChanged;
    }
}
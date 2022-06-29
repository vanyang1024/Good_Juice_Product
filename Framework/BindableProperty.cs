using System;

namespace Demo
{

    public class BindableProperty<T> where T : IEquatable<T>
    {
        private T mValue = default(T);
        public Action<T> OnValueChanged;

        public T Value{
            get {
                return mValue;
            }
            set{
                if(!value.Equals(mValue)){
                    mValue = value;

                    OnValueChanged?.Invoke(value);
                }
            }
        }
    }

}

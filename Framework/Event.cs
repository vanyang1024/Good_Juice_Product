using System;

namespace Demo
{

    public class Event<T> where T : Event<T>
    {
        private static Action mOnEvent;

        public static void Register(Action onEvent){
            mOnEvent += onEvent;
        }

        public static void UnResgiter(Action onEvent){
            mOnEvent -= onEvent;
        }

        public static void Trigger(){
            mOnEvent?.Invoke();
        }

    }

}

﻿namespace cwweb1.Services
{
    public class Calculate
    {
        public Calculate(int initVal)
        {
            Value = initVal;
        }

        private int Value { get; set; }

        public void Decrease(int value)
        {
            this.Value -= value;
        }
        public void Increase(int value)
        {
            this.Value += value;
        }
        public int GetValue()
        {
            return Value;
        }
    }
    

}

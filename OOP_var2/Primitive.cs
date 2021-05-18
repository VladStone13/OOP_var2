using System;

namespace OOP_var2
{
    public abstract class Primitive : Type
    {
        protected Capacity numberBites;

        protected Boolean[] value;

        public Capacity NumberBites
        {
            get => numberBites;
            set => numberBites = value;
        }

        public bool[] Value
        {
            get => value;
            set => this.value = value;
        }
    }
}
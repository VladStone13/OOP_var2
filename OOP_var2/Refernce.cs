namespace OOP_var2
{
    public abstract class Refernce : Type
    {
        protected string memoryAdress;

        protected string reference;

        public string MemoryAdress
        {
            get => memoryAdress;
            set => memoryAdress = value;
        }

        public string Reference
        {
            get => reference;
            set => reference = value;
        }
    }
}
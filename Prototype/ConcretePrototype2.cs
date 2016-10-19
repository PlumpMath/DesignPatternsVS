namespace Prototype
{
    internal class ConcretePrototype2: Prototype
    {
      
        public override Prototype Clone()
        {
            return (Prototype) MemberwiseClone();
        }

        public ConcretePrototype2(string id) : base(id)
        {
        }
    }
}
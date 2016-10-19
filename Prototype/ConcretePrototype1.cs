namespace Prototype
{
    internal class ConcretePrototype1: Prototype
    {
        public override Prototype Clone()
        {
            return (Prototype) MemberwiseClone();
        }

        public ConcretePrototype1(string id) : base(id)
        {
        }
    }
}
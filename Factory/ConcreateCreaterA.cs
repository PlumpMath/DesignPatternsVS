namespace Factory
{
    internal class ConcreateCreaterA : Creater
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }
}
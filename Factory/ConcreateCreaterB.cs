namespace Factory
{
    internal class ConcreateCreaterB : Creater
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}
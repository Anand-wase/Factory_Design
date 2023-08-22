using Factory_Design.Factory.AbstractFactory.AbstractInterface;
using Factory_Design.Factory.AbstractFactory.ConcreteProduct;

namespace Factory_Design.Factory.AbstractFactory.ConcreteFactory
{
    public class DELLFactory : IComputerFactory
    {
        public IBrand Brand()
        {
            return new DELL();

        }

        public IProcessor Processor()
        {
            return new I5();
        }

        public virtual ISystemType SystemType()
        {
            return new Desktop();
        }


    }

    public class DellLaptopFactory : DELLFactory
    {
        public override ISystemType SystemType()
        {
            return new Laptop();
        }
    }
}

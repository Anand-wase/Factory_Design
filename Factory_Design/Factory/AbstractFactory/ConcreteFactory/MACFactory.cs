using Factory_Design.Factory.AbstractFactory.AbstractInterface;
using Factory_Design.Factory.AbstractFactory.ConcreteProduct;

namespace Factory_Design.Factory.AbstractFactory.ConcreteFactory
{
    public class MACFactory : IComputerFactory
    {
        public IBrand Brand()
        {
            return new MAC();
        }

        public IProcessor Processor()
        {
            return new I7();
        }

        public virtual ISystemType SystemType()
        {
            return new Desktop();
        }

        public class MACLaptopFactory : MACFactory
        {

            public override ISystemType SystemType()
            {
                return new Laptop();
            }
        }
    }
}

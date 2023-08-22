using Factory_Design.Factory.AbstractFactory.AbstractInterface;
using static Factory_Design.Factory.AbstractFactory.Enumerations;

namespace Factory_Design.Factory.AbstractFactory.ConcreteProduct
{
    public class Laptop : ISystemType
    {
        public string GetSystemType()
        {
            return ComputerTypes.Laptop.ToString();
        }
    }
    public class Desktop : ISystemType
    {
        public string GetSystemType()
        {
            return ComputerTypes.Desktop.ToString();
        }
    }
}

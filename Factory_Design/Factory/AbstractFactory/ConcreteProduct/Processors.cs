using Factory_Design.Factory.AbstractFactory.AbstractInterface;
using static Factory_Design.Factory.AbstractFactory.Enumerations;

namespace Factory_Design.Factory.AbstractFactory.ConcreteProduct
{
    public class I7 : IProcessor
    {
        public string GetProcessor()
        {
            return Processors.I7.ToString();
        }
    }

    public class I5 : IProcessor
    {
        public string GetProcessor()
        {
            return Processors.I5.ToString();
        }
    }

    public class I3 : IProcessor
    {
        public string GetProcessor()
        {
            return Processors.I3.ToString();
        }
    }
}

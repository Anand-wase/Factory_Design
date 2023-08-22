using Factory_Design.Factory.AbstractFactory.AbstractInterface;
using static Factory_Design.Factory.AbstractFactory.Enumerations;

namespace Factory_Design.Factory.AbstractFactory.ConcreteProduct
{
    public class MAC : IBrand
    {
        public string GetBrand()
        {
            return Brands.Apple.ToString();

        }
    }
}

using Factory_Design.Factory.AbstractFactory.AbstractInterface;
using Factory_Design.Models;
using static Factory_Design.Factory.AbstractFactory.ConcreteFactory.MACFactory;

namespace Factory_Design.Factory.AbstractFactory.ConcreteFactory
{
    public class EmployeeSystemFactory
    {
        public IComputerFactory Create(Employee e)
        {
            IComputerFactory returnValue = null;
            if (e.EmployeeTypeId == 1)
            {
                if (e.JobDescription == "Manager")
                {
                    returnValue = new MACLaptopFactory();

                }
                else
                {
                    returnValue = new MACFactory();
                }
            }

            else if (e.EmployeeTypeId == 2)
            {
                if (e.JobDescription == "Manager")
                {
                    returnValue = new DellLaptopFactory();

                }
                else
                {
                    returnValue = new DELLFactory();
                }

            }

            return returnValue;

        }
    }
}

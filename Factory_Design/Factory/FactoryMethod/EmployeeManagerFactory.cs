using Factory_Design.Models;
namespace Factory_Design.Factory.FactoryMethod
{
    public class EmployeeManagerFactory
    {
        public BaseEmployeeFactory CreateFactory(Employee emp)
        {
            BaseEmployeeFactory returnvalue = null;
            if (emp.EmployeeTypeId==1)
            returnvalue = new PermanentEmployeeFactory(emp);
            else
            returnvalue = new ContracttEmployeeFactory(emp);
            return returnvalue;
        }
    }
}
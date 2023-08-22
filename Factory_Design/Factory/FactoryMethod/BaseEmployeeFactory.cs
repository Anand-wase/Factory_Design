using Factory_Design.Managers;
using Factory_Design.Models;

namespace Factory_Design.Factory.FactoryMethod
{
    public abstract class BaseEmployeeFactory
    {
        protected Employee _emp;
        public BaseEmployeeFactory(Employee emp)
        {
            _emp = emp;
        }
        public Employee ApplySalary()
        {
            IEmployeeManager manager = this.Create();
            _emp.Bonus=manager.GetBonous();
            _emp.HourlyPay=manager.GetPay();
            return _emp;
        }
        public abstract IEmployeeManager Create();
    }
}
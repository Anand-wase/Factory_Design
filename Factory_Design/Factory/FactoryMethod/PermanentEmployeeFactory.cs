using Factory_Design.Managers;
using Factory_Design.Models;
using Microsoft.Identity.Client;

namespace Factory_Design.Factory.FactoryMethod
{
    public class PermanentEmployeeFactory : BaseEmployeeFactory
    {
        public PermanentEmployeeFactory(Employee emp) : base(emp)
        {
        }
        public override IEmployeeManager Create()
        { 
            PermanentEmployeeManager manager = new PermanentEmployeeManager();
            _emp.HouseAllowance = manager.GetHouseAllowane();
            return manager;
        }
    }
}
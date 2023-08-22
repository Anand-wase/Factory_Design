using Factory_Design.Managers;
using Factory_Design.Models;
namespace Factory_Design.Factory.FactoryMethod
{
    public class ContracttEmployeeFactory : BaseEmployeeFactory
    {
        public ContracttEmployeeFactory(Employee emp) : base(emp)
        {
        }
        public override IEmployeeManager Create()
        { 
            ContractEmployeeManager manager = new ContractEmployeeManager();
            _emp.MedicalAllowance = manager.GetMedicalAllowane();
            return manager;
        }
    }
}
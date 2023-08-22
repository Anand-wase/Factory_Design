using Factory_Design.Managers;

namespace Factory_Design.Factory
{
    public class EmployeeManagerFactory
    {
        public IEmployeeManager GetEmployeeManager(int employeeTypeID)
        {
            IEmployeeManager returnvalue = null;
            if (employeeTypeID==1)
                returnvalue = new PermanentEmployeeManager();
            else 
                returnvalue = new ContractEmployeeManager();
            return returnvalue;
        }
    }
}
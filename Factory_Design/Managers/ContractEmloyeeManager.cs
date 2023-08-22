
namespace Factory_Design.Managers
{
    public class ContractEmployeeManager : IEmployeeManager
    {
        public int GetBonous()
        {
            return 5;
        }
        public int GetPay()
        {
            return 12;
        }
        public int GetMedicalAllowane()
        {
            return 100;
        }
    }
}
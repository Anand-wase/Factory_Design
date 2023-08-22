namespace Factory_Design.Managers
{
    public class PermanentEmployeeManager : IEmployeeManager
    {
        public int GetBonous()
        {
            return 10;
        }
        public int GetPay()
        {
            return 8;
        }
        public int GetHouseAllowane()
        {
            return 150;
        }
    }
}
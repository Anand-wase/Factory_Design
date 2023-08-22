using Microsoft.EntityFrameworkCore.Storage;

namespace Factory_Design.Managers
{
    public interface IEmployeeManager
    {
        int GetBonous();
        int GetPay();
    }

}
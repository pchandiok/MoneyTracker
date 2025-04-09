using Money.Models;
using Money.Repositories;

namespace Money;

public interface IBankRepository:IBaseRepository<Bank>
{
    Task<Bank> GetByAccount(string str);
}

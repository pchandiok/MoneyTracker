using Money.Data;
using Money.Models;

namespace Money.Repositories;
public class UserRepository
{
    private readonly ApplicationDbContext _context;

    public UserRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public Task<bool> Create(Bank bank)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Update(Bank bank)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Delete(Bank bank)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Bank>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<bool> Save()
    {
        throw new NotImplementedException();
    }
}

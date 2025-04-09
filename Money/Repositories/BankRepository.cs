using Microsoft.EntityFrameworkCore;
using Money.Models;
using Money.Data;

namespace Money.Repositories;
public class BankRepository:IBankRepository
{
    private readonly ApplicationDbContext _context;

    public BankRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Bank> GetByAccount(string account)
    {
        var bankAccount = await _context.Banks.FirstOrDefaultAsync(b => b.AccountNumber == account);
        return bankAccount;
    }

    public async Task<bool> Create(Bank bank)
    {
        await _context.Banks.AddAsync(bank);
        return await Save();
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

    public async Task<bool> Save()
    {
        var result = await _context.SaveChangesAsync();
        return result > 0;
    }
}

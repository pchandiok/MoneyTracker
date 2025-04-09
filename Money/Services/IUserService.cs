namespace Money.Services;

public interface IUserService
{
    Task<string> GetUserId();
}

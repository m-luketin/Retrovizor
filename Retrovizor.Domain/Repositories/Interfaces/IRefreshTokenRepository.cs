namespace Retrovizor.Domain.Repositories.Interfaces
{
    public interface IRefreshTokenRepository
    {
        string GetRefreshTokenByValue(string username);
    }
}

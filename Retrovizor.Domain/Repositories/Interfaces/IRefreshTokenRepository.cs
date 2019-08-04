namespace Retrovizor.Domain.Repositories.Interfaces
{
    public interface IRefreshTokenRepository
    {
        string GetUserRefreshToken(string token, int userId);
        bool AddRefreshToken(string tokenToAdd, int userId);
        bool DeleteRefreshToken(string tokenToDelete);
        bool RevokeUserTokens(int userId);
    }
}

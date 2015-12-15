using Core.Infrastructure;
using Core.Model.Entities;

namespace Core.Model.Repositories
{
    public interface IRefreshTokenRepository : IRepository<RefreshToken, int>
    {
    }
}

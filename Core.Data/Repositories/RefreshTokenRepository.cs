using Core.Model.Entities;
using Core.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Repositories
{
    public class RefreshTokenRepository : Repository<RefreshToken>, IRefreshTokenRepository
    {
        public async Task<bool> AddRefreshToken(RefreshToken token)
        {

            var existingToken = DataContextFactory.GetDataContext().Set<RefreshToken>().Where(x => x.Subject == token.Subject && x.ClientId == token.ClientId).SingleOrDefault();

            if (existingToken != null)
            {
                var result = await RemoveRefreshToken(existingToken);
            }

            DataContextFactory.GetDataContext().Set<RefreshToken>().Add(token);

            return await DataContextFactory.GetDataContext().SaveChangesAsync() > 0;
        }

        public async Task<bool> RemoveRefreshToken(string refreshTokenId)
        {
            var refreshToken = await DataContextFactory.GetDataContext().Set<RefreshToken>().FindAsync(refreshTokenId);

            if (refreshToken != null)
            {
                DataContextFactory.GetDataContext().Set<RefreshToken>().Remove(refreshToken);
                return await DataContextFactory.GetDataContext().SaveChangesAsync() > 0;
            }

            return false;
        }

        public async Task<bool> RemoveRefreshToken(RefreshToken refreshToken)
        {
            DataContextFactory.GetDataContext().Set<RefreshToken>().Remove(refreshToken);
            return await DataContextFactory.GetDataContext().SaveChangesAsync() > 0;
        }

        public async Task<RefreshToken> FindRefreshToken(string refreshTokenId)
        {
            var refreshToken = await DataContextFactory.GetDataContext().Set<RefreshToken>().FindAsync(refreshTokenId);

            return refreshToken;
        }

        public List<RefreshToken> GetAllRefreshTokens()
        {
            return DataContextFactory.GetDataContext().Set<RefreshToken>().ToList();
        }
    }
}

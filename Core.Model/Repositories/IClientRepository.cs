using Core.Infrastructure;
using Core.Model.Entities;

namespace Core.Model.Repositories
{
    public interface IClientRepository : IRepository<Client, int>
    {
        Client FindClient(int clientId);
    }
}

using Core.Infrastructure;
using Core.Model.Entities;

namespace Core.Model.Repositories
{
    public interface IClientRepository : IRepository<Client, string>
    {
        Client FindClient(string clientId);
    }
}

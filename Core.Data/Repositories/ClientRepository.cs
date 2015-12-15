using Core.Model.Entities;
using Core.Model.Repositories;

namespace Core.Data.Repositories
{
    public class ClientRepository : Repository<Client>, IClientRepository
    {
        public Client FindClient(int clientId)
        {
            return DataContextFactory.GetDataContext().Set<Client>().Find(clientId);
        }
    }
}

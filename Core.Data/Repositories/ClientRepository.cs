using System;
using System.Linq.Expressions;
using Core.Model.Entities;
using Core.Model.Repositories;

namespace Core.Data.Repositories
{
    public class ClientRepository : Repository<Client>, IClientRepository
    {
        public Client FindById(string clientId, params Expression<Func<Client, object>>[] includeProperties)
        {
            return DataContextFactory.GetDataContext().Set<Client>().Find(clientId);
        }

        public Client FindClient(string clientId)
        {
            return DataContextFactory.GetDataContext().Set<Client>().Find(clientId);
        }

        public void Remove(string id)
        {
            DataContextFactory.GetDataContext().Set<Client>().Remove(FindById(id, (x => x.Id)));
        }
    }
}

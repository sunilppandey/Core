using Core.Infrastructure;
using Core.Model.Entities;
using System.Collections.Generic;

namespace Core.Model.Repositories
{
    public interface IBookRepository : IRepository<Book, int>
    {
        Book FindByAuthor(string author);
    }
}

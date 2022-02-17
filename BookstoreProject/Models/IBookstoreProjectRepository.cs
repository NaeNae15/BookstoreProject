using System;
using System.Linq;

namespace BookstoreProject.Models
{
    public interface IBookstoreProjectRepository
    {
        IQueryable<Book> Books { get; }
    }
}

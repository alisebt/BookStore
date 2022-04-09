using System.Collections.Generic;

namespace BookStore.Core
{
    public interface IBookServices
    {
        List<Book> GetList();
        Book Get(string Id);
        Book Add(Book book);
    }
}

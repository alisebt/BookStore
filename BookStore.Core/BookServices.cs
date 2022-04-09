using MongoDB.Driver;
using System.Collections.Generic;

namespace BookStore.Core
{
    public class BookServices : IBookServices
    {
        private readonly IMongoCollection<Book> _books;

        public BookServices(IDbClient dbClient)
        {
            _books = dbClient.GetBooksCollection();
        }
        public List<Book> GetList()
        {
            return _books.Find(x => true).ToList();
        }
        public Book Add(Book book)
        {
            _books.InsertOne(book);
            return book;
        }

        public Book Get(string id)
        {
            return _books.Find(x => x.Id == id).FirstOrDefault();
        }
    }
}

using Store;
using System;
using System.Linq;

namespace StoreMemory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1, "Perfect code"),
            new Book(2, "CLR Via C#"),
            new Book(3, ".NET for lammers"),
        };

        public Book[] GetAllByTitle(string titlePart)
        {
            return books.Where(Book => Book.Title.Contains(titlePart))
                        .ToArray();
        }
    }
}

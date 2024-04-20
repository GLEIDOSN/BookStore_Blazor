using BookStore.Domain.Entities;

namespace BookStore.Domain.Abstractions
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetBooks();
        Task<Book?> GetBook(int id);
        Task<Book> AddBook(Book book);
        Task DeleteBook(int id);
        Task UpdataBook(Book book);
    }
}

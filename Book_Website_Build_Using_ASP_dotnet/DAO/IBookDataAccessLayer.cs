using Book_Website_Build_Using_ASP_dotnet.Models;

namespace Book_Website_Build_Using_ASP_dotnet.DAO
{
    public interface IBookDataAccessLayer
    {
        public IEnumerable<books> GetAllBooks();
        public books GetBook(int id);
        public void AddBooks(books _book);
        public void DeleteBooks(int id,books _book);
        public void UpdateBooks(int id, books _book);

    }
}

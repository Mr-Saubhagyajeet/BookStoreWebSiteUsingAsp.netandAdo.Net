using Book_Website_Build_Using_ASP_dotnet.Models;
using System.Data;
using System.Data.SqlClient;

namespace Book_Website_Build_Using_ASP_dotnet.DAO
{
    public class BookDataAccessLayer : IBookDataAccessLayer
    {
        public IConfiguration Configuration { get; }
        public BookDataAccessLayer(IConfiguration configuration) 
        {
            Configuration = configuration;
        }
        public IEnumerable<books> GetAllBooks()
        {
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            List<books> _book = new List<books>() ;
            SqlConnection connection = new SqlConnection();
            string querry = "Select * from books";
            SqlDataAdapter adapter = new SqlDataAdapter(querry,connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet,"BooksTable");
            foreach(DataRow dataRow in dataSet.Tables[0].Rows) 
            {
                books _Books = new books() ;
                _Books.BookId = Convert.ToInt32(dataRow[0]);
                _Books.BookTitle = dataRow[1].ToString();
                _Books.BookAuthor = dataRow[2].ToString();
                _Books.BookImage = dataRow[3].ToString();
                _Books.BookDescription = dataRow[4].ToString();
                _Books.BookPrice = float.Parse(dataRow[5].ToString());
                _book.Add(_Books);
            }
            return _book;
        }
        public void AddBooks(books _book)
        {
            throw new NotImplementedException();
        }

        public void DeleteBooks(int id, books _book)
        {
            throw new NotImplementedException();
        }


        public books GetBook(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateBooks(int id, books _book)
        {
            throw new NotImplementedException();
        }
    }
}

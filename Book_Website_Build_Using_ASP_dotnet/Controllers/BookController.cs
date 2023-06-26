using Book_Website_Build_Using_ASP_dotnet.DAO;
using Microsoft.AspNetCore.Mvc;

namespace Book_Website_Build_Using_ASP_dotnet.Controllers
{
    public class BookController : Controller
    {
        BookDataAccessLayer bookDAO;
        public BookController(IConfiguration configuration) 
        {
            bookDAO = new BookDataAccessLayer(configuration);
        }
        public IActionResult AllBooks()
        {
            bookDAO.GetAllBooks();
            return View();
        }
    }
}

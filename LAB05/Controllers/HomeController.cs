using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LAB05.Models;

namespace LAB05.Controllers;

public class HomeController : Controller
{
    public List<Author> Authors = new List<Author>([ new Author(1,"Yasir","Pakistan"), new Author(2,"Shiva","India")]);

    public static List<Book> Books = new List<Book>([
        new Book(1, "Marvus", 1234, 1), new Book(2, "Bravo", 345, 2), new Book(3, "Matrix", 3000, 1)
    ]);    
    public IActionResult Index()
    {
        List<BookCardViewModel> bookCards = new List<BookCardViewModel>();
        foreach (Book b in Books)
        {
            string authorName = Authors.Where(a => a.Id == b.AuthorId).FirstOrDefault().Name;
            BookCardViewModel bookCardViewModel =
                new BookCardViewModel(b.Id, b.Price, b.Title , authorName);
            bookCards.Add(bookCardViewModel);
        }
        HomeViewModel homeViewModel = new HomeViewModel(bookCards, Authors);
        return View(homeViewModel);
    }

    [HttpPost]
    public IActionResult AddBook()
    {
        return View();
    }
    public ViewResult About()
    {
        return View();
    }

    public ViewResult Contact()
    {
        return View();
    }
}

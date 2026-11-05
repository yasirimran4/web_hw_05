public class HomeViewModel
{
    public List<BookCardViewModel> Books = new List<BookCardViewModel>();
    public List<Author> Authors = new List<Author>();

    public HomeViewModel(List<BookCardViewModel> books, List<Author> authors)
    {
        Books = books;
        Authors = authors;
    }
}
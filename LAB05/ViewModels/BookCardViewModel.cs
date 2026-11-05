public class BookCardViewModel
{
    public int Id { get; set; }
    public decimal Price { get; set; }
    public string Title { get; set; }
    public string AuthorName { get; set; }

    public BookCardViewModel(){}
    
    public BookCardViewModel(int id, decimal price, string title, string authorName)
    {
        Id = id;
        Price = price;
        Title = title;
        AuthorName = authorName;
    }
    
}
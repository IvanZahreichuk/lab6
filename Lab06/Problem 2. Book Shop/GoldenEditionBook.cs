namespace Lab06.Problem_2._Book_Shop;

public class GoldenEditionBook : Book
{
    public GoldenEditionBook(string title, string author, decimal price)
        : base(title, author, price)
    {
    }

    public override decimal Price
    {
        get => base.Price * 1.3m;
    }
}
using System.Text;

namespace Lab06.Problem_2._Book_Shop;

public class Book
{
    private string _title;
    private string _author;
    private decimal _price;

    public Book(string author, string title, decimal price)
    {
        this.Title = title;
        this.Author = author;
        this.Price = price;
    }

    public string Author
    {
        get => this._author;
        protected set
        {
            var indexOf = value.IndexOf(' ');
            if (char.IsDigit(value[indexOf + 1]))
            {
                throw new ArgumentException("Author not valid!");
            }

            this._author = value;
        }
    }

    public string Title
    {
        get => this._title;
        protected set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Title not valid!");
            }

            this._title = value;
        }
    }

    public virtual decimal Price
    {
        get => this._price;
        protected set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Price not valid!");
            }

            this._price = value;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("Type: ").AppendLine(this.GetType().Name)
            .Append("Title: ").AppendLine(this.Title)
            .Append("Author: ").AppendLine(this.Author)
            .Append("Price: ").Append($"{this.Price:f1}")
            .AppendLine();

        return sb.ToString();
    }
}
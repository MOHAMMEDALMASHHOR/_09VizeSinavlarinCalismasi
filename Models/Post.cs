namespace TelegramApp.Models;
public abstract class Post : IComparable,IFormattable
{

    public int Id { get; set; }
    public string? Title { get; set; }
    public double Size { get; set; }
    protected Post(int id, string? title, double size)
    {
        Id = id;
        Title = title;
        Size = size;
    }

    public int CompareTo(object? obj)
    {
        throw new NotImplementedException();
    }

    public string ToString(string? format="id", IFormatProvider? formatProvider=null)
    {
        switch (format.ToLowerInvariant())
        {

            case "id":
                return $"{Id} _ {Title} _ {Size}";   
            default:
                return $"{Title} _ {Id} _ {Size}";   
        }
    }
    
}

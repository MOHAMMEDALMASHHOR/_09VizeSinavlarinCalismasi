namespace TelegramApp.Models;

public class PostNotFoundException : NotFoundException
{
    public PostNotFoundException(int id) : base($"There is no Post with the id: {id}")
    {
    }
}
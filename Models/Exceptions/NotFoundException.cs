namespace TelegramApp.Models;
public abstract class NotFoundException:Exception
{
    public NotFoundException(string mesaage):base(mesaage)
    {
        
    }
}

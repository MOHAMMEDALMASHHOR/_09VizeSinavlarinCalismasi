namespace TelegramApp.Models;

public class ImportantPost : Post
{
    public string? Priority { get; private set; }
    public string SetPriority(int value){
        switch (value)
        {
            case 1:
                Priority = "Importnat";
                return Priority;
            case 2:
                Priority = "very Importnat";
                return Priority;
                
            
            default:
                Priority = "Not Important";
                return Priority;
                
        }
    }
    public ImportantPost(int id, string? title, double size,int value) : base(id, title, size)
    {
        Priority = SetPriority(value);
    }
    
}
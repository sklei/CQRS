namespace CQRS.Domain.Models;

public class TodoItem 
{
    public TodoItem()
    {
        ID = Guid.NewGuid();
    }

    public Guid ID { get; private set;}

    public string? Title { get; set; }
    public bool Done { get; set; }
}
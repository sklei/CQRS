using CQRS.Domain.Models;

namespace CQRS.Repositories;

public class TodoRepository
{
    public List<TodoItem> Todos { get; set; }

    public TodoRepository()
    {
        Todos = new List<TodoItem> {
            new TodoItem() { Title = "Item #1", Done = true },
            new TodoItem() { Title = "Item #2", Done = true },
            new TodoItem() { Title = "Item #3", Done = false },
            new TodoItem() { Title = "Item #4", Done = false },
            new TodoItem() { Title = "Item #5", Done = false }
        };
    }

    // public void Add(TodoItem item) => Todos.Add(item);

    // public IEnumerable<TodoItem> GetAll() => Todos;

    // public TodoItem? Get(Guid Id) => Todos.FirstOrDefault(t => t.ID == Id);
}
using CQRS.Domain.Models;
using MediatR;

namespace CQRS.Domain.Events;

public class TodoItemCreatedEvent : BaseCreatedEvent
{
    public TodoItemCreatedEvent(TodoItem item)
    {
        Item = item;
    }

    public TodoItem Item { get; }
}

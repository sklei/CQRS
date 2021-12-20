using CQRS.Domain.Events;
using MediatR;

namespace CQRS.Core.Todo;

public class InvalidateCacheEventHandler : INotificationHandler<TodoItemCreatedEvent>
{
    private readonly ILogger<InvalidateCacheEventHandler> _logger;

    public InvalidateCacheEventHandler(ILogger<InvalidateCacheEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(TodoItemCreatedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Cache Invalidated after create! (We don't have cache, but still...)");

        return Task.CompletedTask;
    }
}
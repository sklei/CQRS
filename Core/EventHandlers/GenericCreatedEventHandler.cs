using CQRS.Domain.Events;
using MediatR;

namespace CQRS.Core.Todo;

public class GenericCreatedEventHandler : INotificationHandler<BaseCreatedEvent>
{
    private readonly ILogger<GenericCreatedEventHandler> _logger;

    public GenericCreatedEventHandler(ILogger<GenericCreatedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(BaseCreatedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Some generic thing is created!");

        return Task.CompletedTask;
    }
}

using CQRS.Domain.Events;
using MediatR;

namespace CQRS.Core.Todo;

public class GenericCreatedEventHandler : INotificationHandler<CreatedEventBase>
{
    private readonly ILogger<GenericCreatedEventHandler> _logger;

    public GenericCreatedEventHandler(ILogger<GenericCreatedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(CreatedEventBase notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Some generic thing is created!");

        return Task.CompletedTask;
    }
}

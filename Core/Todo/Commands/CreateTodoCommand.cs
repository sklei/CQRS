using MediatR;
using CQRS.Repositories;
using CQRS.Domain.Models;
using CQRS.Domain.Events;

namespace CQRS.Core.Todo;

public class CreateTodoCommand : IRequest<Guid>
{
    public string? Title { get; set; }
}

public class CreateTodoCommandHandler : IRequestHandler<CreateTodoCommand, Guid>
{
    private readonly TodoRepository _todoRepository;
    private readonly IPublisher _publisher;

    public CreateTodoCommandHandler(TodoRepository todoRepository, IPublisher publisher)
    {
        _todoRepository = todoRepository;
        _publisher = publisher;
    }

    public async Task<Guid> Handle(CreateTodoCommand request, CancellationToken cancellationToken)
    {
        var entity = new TodoItem()
        {
            Title = request.Title
        };

        _todoRepository.Todos.Add(entity);

        await _publisher.Publish(new TodoItemCreatedEvent(entity));

        return entity.ID;
    }
}
using MediatR;
using CQRS.Repositories;
using CQRS.Domain.Models;

namespace CQRS.Core.Todo;

public class GetTodosQuery : IRequest<IEnumerable<TodoItem>>
{

}

public class GetTodosQueryHandler : IRequestHandler<GetTodosQuery, IEnumerable<TodoItem>>
{
    private readonly TodoRepository _todoRepository;

    public GetTodosQueryHandler(TodoRepository todoRepository)
    {
        _todoRepository = todoRepository;
    }
    
    public Task<IEnumerable<TodoItem>> Handle(GetTodosQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_todoRepository.Todos.AsEnumerable());
    }
}
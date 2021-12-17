using MediatR;
using CQRS.Repositories;
using CQRS.Domain.Models;

namespace CQRS.Core.Todo;

public class GetTodosSlowQuery : IRequest<IEnumerable<TodoItem>>
{

}

public class GetTodosSlowQueryHandler : IRequestHandler<GetTodosSlowQuery, IEnumerable<TodoItem>>
{
    private readonly TodoRepository _todoRepository;

    public GetTodosSlowQueryHandler(TodoRepository todoRepository)
    {
        _todoRepository = todoRepository;
    }
    
    public async Task<IEnumerable<TodoItem>> Handle(GetTodosSlowQuery request, CancellationToken cancellationToken)
    {
        await Task.Delay(2000);
        return _todoRepository.Todos.AsEnumerable();
    }
}
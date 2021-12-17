using Microsoft.AspNetCore.Mvc;
using CQRS.Core.Todo;
using CQRS.Domain.Models;

namespace CQRS.Controllers;

public class TodoController : ApiControllerBase
{
    [HttpPost]
    public async Task<Guid> Create(CreateTodoCommand req)
    {
        return await Mediator.Send(req);
    }

    [HttpGet]
    public async Task<IEnumerable<TodoItem>> Get()
    {
        var req = new GetTodosQuery();
        return await Mediator.Send(req);
    }

    [HttpGet("slow")]
    public async Task<IEnumerable<TodoItem>> GetSlow()
    {
        var req = new GetTodosSlowQuery();
        return await Mediator.Send(req);
    }
}
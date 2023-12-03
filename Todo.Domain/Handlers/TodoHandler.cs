using Flunt.Notifications;
using Todo.Domain.Commands;
using Todo.Domain.Commands.Contracts;
using Todo.Domain.Handlers.Contracts;
using Todo.Domain.Repositories;

namespace Todo.Domain.Handlers
{
    public class TodoHandler(ITodoRepository repository) : Notifiable, IHandler<CreateTodoCommand, GenericCommandResult<ICommandResult>>
    {
        private readonly ITodoRepository _repository = repository;

        public Task<GenericCommandResult<ICommandResult>> Handle(CreateTodoCommand request)
        {
            return null;
        }
    }
}

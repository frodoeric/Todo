using Flunt.Notifications;
using Flunt.Validations;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
    public sealed class MarkTodoAsUnDoneCommand(Guid id, string user) : Notifiable, ICommand
    {
        public Guid Id { get; set; } = id;
        public string User { get; set; } = user;

        public void Validate()
        {
            AddNotifications(
                new Contract()
                .Requires()
                .HasMinLen(User, 6, "User", "Invalid User!")                        
            );
        }
    }
}



using System.ComponentModel.DataAnnotations;
using Flunt.Notifications;
using Flunt.Validations;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
    public class UpdateTodoCommand(Guid id, string title, string user) : Notifiable, ICommand
    {
        public Guid Id { get; set; } = id;
        public string Title { get; set; } = title;
        public string User { get; set; } = user;

        public void Validate()
        {
            AddNotifications(
                new Contract()
                .Requires()
                .HasMinLen(Title, 3, "Title", "Please, give a better task describe!")
                .HasMinLen(User, 6, "User", "Invalid User!")                        
            );
        }
    }
}
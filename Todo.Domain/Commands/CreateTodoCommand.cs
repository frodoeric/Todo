
using System.ComponentModel.DataAnnotations;
using Flunt.Notifications;
using Flunt.Validations;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
    public class CreateTodoCommand : Notifiable, ICommand
    {
        public CreateTodoCommand()
        {
            
        }

        public CreateTodoCommand(string title, string user, DateTime dueDate)
        {
            Title = title;
            User = user;
            DueDate = dueDate;
        }

        public string Title { get; set; }
        public string User { get; set; }
        public DateTime DueDate { get; set; }
        
        public void Validate()
        {
            //design by contract e.g isNull, isFalse
            AddNotifications(
                new Contract()
                .Requires()
                .HasMinLen(Title, 3, "Title", "Please, give a better task describe!")
                .HasMinLen(User, 6, "User", "Invalid User!")                        
            );
        }
    }
}
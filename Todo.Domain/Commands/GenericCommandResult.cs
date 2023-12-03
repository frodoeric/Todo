
using Todo.Domain.Commands;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
    public class GenericCommandResult<T> : ICommandResult
    {
        public GenericCommandResult()
        {
            
        }
        
        public GenericCommandResult(bool success, string message, T data)
        {
            Success = success;
            Message = message;
            Data = data;
        }

        public bool Success { get; }
        public string Message { get; }
        public T Data { get; }
    }
}

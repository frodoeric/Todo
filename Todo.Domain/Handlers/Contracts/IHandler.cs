using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Handlers.Contracts
{
    public interface IHandler<TRequest, TResponse> where TRequest : ICommand
    {
        Task<TResponse> Handle(TRequest request);
    }
}

namespace CleanArchitecture.NET.Interfaces;

public interface IUseCase<TRequest, TOutput> where TRequest : RequestBase
{
    Task<TOutput> Execute(TRequest request);
}

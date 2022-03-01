namespace CleanArchitecture.NET.Interfaces;

public interface IUseCaseAsync<TRequest, TOutput> where TRequest : RequestBase
{
    Task<TOutput> Execute(TRequest request);
}

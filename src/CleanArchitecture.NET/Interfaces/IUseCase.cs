namespace CleanArchitecture.NET.Interfaces;

public interface IUseCase<TRequest, TOutput> where TRequest : RequestBase
{
    TOutput Execute(TRequest request);
}

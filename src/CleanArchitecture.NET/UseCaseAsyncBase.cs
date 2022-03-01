using CleanArchitecture.NET.Interfaces;

namespace CleanArchitecture.NET;

public abstract class UseCaseAsyncBase<TRequest, TOutput> : IUseCaseAsync<TRequest, TOutput>
    where TRequest : RequestBase
{
    // TODO Logger?

    public abstract Task<TOutput> Execute(TRequest request);
}

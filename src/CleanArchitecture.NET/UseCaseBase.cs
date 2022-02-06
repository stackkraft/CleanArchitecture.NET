using CleanArchitecture.NET.Interfaces;

namespace CleanArchitecture.NET;

public abstract class UseCaseBase<TRequest, TOutput> : IUseCase<TRequest, TOutput>
    where TRequest : RequestBase
{
    // TODO Logger?

    public abstract Task<TOutput> Execute(TRequest request);
}

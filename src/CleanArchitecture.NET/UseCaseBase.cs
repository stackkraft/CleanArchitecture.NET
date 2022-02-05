namespace CleanArchitecture.NET;

public abstract class UseCaseBase<TRequest, TOutput> where TRequest : RequestBase
{
    public abstract Task<TOutput> Execute(TRequest request);
}

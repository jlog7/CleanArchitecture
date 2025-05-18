namespace CleanArchitecture.Domain.Abstractions;

public abstract class Entity
{
    public Guid Id { get; init; }
    private readonly List<IDomainEvent> _domainEvents = new();
    protected Entity(Guid id)
    {
        Id = id;
    }
    public IReadOnlyList<IDomainEvent> GetDomaintEvents()
    {
        return _domainEvents.ToList();
    }
    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }
    protected void RaiseDomainEvent(IDomainEvent domaintEvent)
    {
        _domainEvents.Add(domaintEvent);
    }
}
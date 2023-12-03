namespace Todo.Domain.Entities;

public abstract class Entity : IEquatable<Entity>
{
    public Guid Id { get; private set; }

    public virtual bool Equals(Entity? other)
    {
        return other is not null && Id == other.Id;
    }
}

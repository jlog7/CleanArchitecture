using CleanArchitecture.Domain.Abstractions;

namespace CleanArchitecture.Domain.Alquileres;

public sealed class Alquileres : Entity
{   
    public AquilerStatus Status { get; private set; }
    public Alquileres(Guid id) : base(id)
    {

    }
}

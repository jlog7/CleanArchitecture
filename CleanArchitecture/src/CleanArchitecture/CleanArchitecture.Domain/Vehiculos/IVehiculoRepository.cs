namespace CleanArchitecture.Domain.Vehiculos;

public interface IVehiculoRepsository
{
    Task<Vehiculo?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
}
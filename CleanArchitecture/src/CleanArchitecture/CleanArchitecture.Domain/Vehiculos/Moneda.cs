namespace CleanArchitecture.Domain.Vehiculos;

public record Moneda(decimal monto, TipoMoneda TipoMoneda)
{
    public static Moneda operator +(Moneda primero, Moneda segundo)
    {
        if (primero.TipoMoneda != segundo.TipoMoneda)
        {
            throw new InvalidOperacionException("El tipo de moneda debe ser el mismo");
        }
        return new Moneda(primero.monto + segundo.monto, primero.tipoMoneda);
    }

    public static Moneda Zero() => new(0, TipoMoneda.None);
    public static Moneda Zero(TipoMoneda tipoMoneda) => new(0, tipoMoneda);

}
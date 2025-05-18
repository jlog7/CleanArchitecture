namespace CleanArchitecture.Domain.Alquileres;

public sealed record DateRange
{
    public DateOnly Inicio { get; init; }
    public DateOnly Fin { get; init; }

    public int CatntidadDias => Fin.DayNumber - Inicio.DayNumber;
    private DateRange()
    {
    }
    public static DateRange Create(DateOnly inicio, DateOnly fin)
    {
        if (inicio > fin)
        {
            throw new ApplicationException("La fecha final es anterior a la fecha de incio");
        }

        return new DateRange
        {
            Inicio = inicio,
            Fin = fin
        };
    }
}
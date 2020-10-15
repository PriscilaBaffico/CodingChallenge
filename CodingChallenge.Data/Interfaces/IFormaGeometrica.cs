using CodingChallenge.Data.Enums;

namespace CodingChallenge.Data.Interfaces
{
     public interface IFormaGeometrica
    {
        EnumFormas Tipo { get; }
        string obtenerKey(bool esPlural);
        decimal CalcularArea();
        decimal CalcularPerimetro();
    }
}

using CodingChallenge.Data.Enums;

namespace CodingChallenge.Data.Interfaces
{
     interface IFormaGeometrica
    {
        decimal _lado { get; set; }
        Formas Tipo { get; set; }
        decimal CalcularArea();
        decimal CalcularPerimetro();
    }
}

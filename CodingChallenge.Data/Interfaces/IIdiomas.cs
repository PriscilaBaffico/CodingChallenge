using CodingChallenge.Data.Enums;

namespace CodingChallenge.Data.Interfaces
{
    interface IIdiomas
    {
        string Header(bool vacio);
        string Linea(int cantidad, decimal area, decimal perimetro, Formas tipo);
        string Footer(int totalFiguras, decimal totalAreas, decimal totalPerimetro);
    }
}

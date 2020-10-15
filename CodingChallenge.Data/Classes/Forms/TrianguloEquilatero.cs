using CodingChallenge.Data.Enums;
using CodingChallenge.Data.Interfaces;
using System;

namespace CodingChallenge.Data.Classes.Forms
{
    public class TrianguloEquilatero : IFormaGeometrica
    {
        public decimal Lado { get; private set; }
        public EnumFormas Tipo { get; } = EnumFormas.TrianguloEquilatero;
        public TrianguloEquilatero(decimal lado)
        {
            this.Lado = lado;
        }

        public string obtenerKey(bool esPlural)
        {
            if (esPlural)
                return "Triangulos_Key";
            return "Triangulo_Key";
        }
        public decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * Lado * Lado;
        }
        public decimal CalcularPerimetro()
        {
            return Lado * 3;
        }
    }
}

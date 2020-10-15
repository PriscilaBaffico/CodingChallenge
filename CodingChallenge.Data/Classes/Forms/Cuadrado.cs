using CodingChallenge.Data.Enums;
using CodingChallenge.Data.Interfaces;
using System;

namespace CodingChallenge.Data.Classes.Forms
{
    public class Cuadrado : IFormaGeometrica
    {
        public decimal Lado { get; private set; }
        public EnumFormas Tipo { get; } = EnumFormas.Cuadrado;

        public Cuadrado(decimal lado)
        {
            this.Lado = lado;
        }
        public string obtenerKey(bool esPlural)
        {
            if (esPlural)
                return "Cuadrados_Key";
            return "Cuadrado_Key";
        }

        public decimal CalcularArea()
        {
            return Lado * Lado;
        }
        public decimal CalcularPerimetro()
        {
            return Lado * 4;
        }
    }
}

using CodingChallenge.Data.Enums;
using CodingChallenge.Data.Interfaces;
using System;

namespace CodingChallenge.Data.Classes.Forms
{
    public class Circulo : IFormaGeometrica
    {
        public decimal Diametro { get; private set; }
        public EnumFormas Tipo { get; } = EnumFormas.Circulo;

        public Circulo(decimal diametro)
        {
            this.Diametro = diametro;
        }
        public string obtenerKey(bool esPlural)
        {
            if (esPlural)
                return "Circulos_Key";
            return "Circulo_Key";
        }
        public decimal CalcularArea()
        {
            return (decimal)Math.PI * (Diametro / 2) * (Diametro / 2); ;
        }
        public decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * Diametro;
        }

    }
}

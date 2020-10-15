using CodingChallenge.Data.Enums;
using CodingChallenge.Data.Interfaces;
using System;

namespace CodingChallenge.Data.Classes.Forms
{
    public class Trapecio : IFormaGeometrica
    {
        public decimal LadoA { get; private set; }
        public decimal LadoB { get; private set; }
        public decimal LadoC { get; private set; }
        public decimal LadoD { get; private set; }
        public EnumFormas Tipo { get; } = EnumFormas.Trapecio;

        public Trapecio(decimal ladoA, decimal ladoB, decimal ladoC, decimal ladoD) 
        {
            this.LadoA = ladoA;
            this.LadoB = ladoB;
            this.LadoC = ladoC;
            this.LadoD = ladoD;       
        }
        public string obtenerKey(bool esPlural)
        {
            if (esPlural)
                return "Trapecios_Key";
            return "Trapecio_Key";
        }
        public decimal CalcularArea()
        {
            double a = Convert.ToDouble(LadoA);
            double b = Convert.ToDouble(LadoB);
            double c = Convert.ToDouble(LadoC);
            double d = Convert.ToDouble(LadoD);
            double primerTermino = (a + b) / 2;
            double segundoTermino = Math.Pow(c, 2);
            double tercerTermino = Math.Round(Math.Pow((Math.Pow(c, 2) - Math.Pow(d, 2) + Math.Pow((a - b), 2)) / (2 * (a - b)), 2), 2);
            double area = Math.Round(primerTermino * Math.Sqrt(segundoTermino - tercerTermino), 2);

            return Convert.ToDecimal(area);
        }
        public decimal CalcularPerimetro()
        {
            return LadoA + LadoB + LadoC + LadoD;
        }
    }
}

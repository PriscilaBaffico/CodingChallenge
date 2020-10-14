using CodingChallenge.Data.Enums;
using CodingChallenge.Data.Interfaces;
using System;

namespace CodingChallenge.Data.Classes.Forms
{
    class Trapecio : IFormaGeometrica
    {
        public decimal _LadoB { get; set; }
        public decimal _LadoC { get; set; }
        public decimal _LadoD { get; set; }

        #region Implementacion de IFormaGeometrica
        //lado A
        public decimal _lado { get; set; }
        public Formas Tipo { get; set; } = Formas.Trapecio;

        public decimal CalcularArea()
        {
            double a = Convert.ToDouble(this._lado);
            double b = Convert.ToDouble(this._LadoB);
            double c = Convert.ToDouble(this._LadoC);
            double d = Convert.ToDouble(this._LadoD);
            double primerTermino = (a + b) / 2;
            double segundoTermino = Math.Pow(c, 2);
            double tercerTermino = Math.Pow((Math.Pow(c, 2) - Math.Pow(d, 2) + (Math.Pow((a - b), 2)) / (2 * (a - b))), 2);
            double area = primerTermino * Math.Sqrt(segundoTermino - tercerTermino);

            return Convert.ToDecimal(area);
        }

        public decimal CalcularPerimetro()
        {
            return this._lado + this._LadoB + this._LadoC +this._LadoD;
        }

        #endregion

    }
}

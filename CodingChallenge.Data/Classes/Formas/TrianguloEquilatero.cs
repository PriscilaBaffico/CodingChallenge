using CodingChallenge.Data.Enums;
using CodingChallenge.Data.Interfaces;
using System;

namespace CodingChallenge.Data.Classes.Forms
{
    class TrianguloEquilatero : IFormaGeometrica
    {
        #region Implementacion de IFormaGeometrica
        public decimal _lado { get; set; }
        public Formas Tipo { get; set; } = Formas.TrianguloEquilatero;
        public decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        }

        public decimal CalcularPerimetro()
        {
            return _lado * 3;
        }

        #endregion
    }
}

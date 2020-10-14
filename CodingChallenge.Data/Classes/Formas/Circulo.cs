using CodingChallenge.Data.Enums;
using CodingChallenge.Data.Interfaces;
using System;

namespace CodingChallenge.Data.Classes.Forms
{
    public class Circulo : IFormaGeometrica
    {
        #region Implementacion de IFormaGeometrica
        public decimal _lado { get; set; }
        public Formas Tipo { get; set; } = Formas.Circulo;
        public decimal CalcularArea()
        {
            return (decimal)Math.PI * (_lado / 2) * (_lado / 2); ;
        }

        public decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * _lado;
        }

        #endregion
    }
}

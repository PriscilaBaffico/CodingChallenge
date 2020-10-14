using CodingChallenge.Data.Enums;
using CodingChallenge.Data.Interfaces;
using System;

namespace CodingChallenge.Data.Classes.Forms
{
    class Cuadrado : IFormaGeometrica
    {
        #region Implementacion de IFormaGeometrica
        public decimal _lado { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Formas Tipo { get; set; } = Formas.Cuadrado;
        
        public decimal CalcularArea()
        {
            return _lado * _lado;
        }

        public decimal CalcularPerimetro()
        {
            return _lado * 4;
        }

        #endregion
    }
}

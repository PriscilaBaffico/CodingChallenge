using CodingChallenge.Data.Enums;
using CodingChallenge.Data.Interfaces;

namespace CodingChallenge.Data.Classes.Forms
{
    public class Rectangulo : IFormaGeometrica
    {
        public decimal _Segundolado { get; set; }
        
        #region Implementacion de IFormaGeometrica
        public decimal _lado { get ; set ; }
        public Formas Tipo { get; set; } = Formas.Rectangulo;
        public decimal CalcularArea()
        {
            return _Segundolado * _lado;
        }

        public decimal CalcularPerimetro()
        {
            return _lado * 2 + _Segundolado * 2;
        }


        #endregion
    }
}

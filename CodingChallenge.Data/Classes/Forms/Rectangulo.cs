using CodingChallenge.Data.Enums;
using CodingChallenge.Data.Interfaces;

namespace CodingChallenge.Data.Classes.Forms
{
    public class Rectangulo : IFormaGeometrica
    {
        public decimal LadoA { get; private set; }
        public decimal LadoB { get ; private set ; }
        public EnumFormas Tipo { get; } = EnumFormas.Rectangulo;
        
        public Rectangulo(decimal ladoA, decimal ladoB)
        {
            this.LadoA = ladoA;
            this.LadoB = ladoB;
        }
        public string obtenerKey(bool esPlural)
        {
            if (esPlural)
                return "Rectangulos_Key";
            return "Rectangulo_Key";
        }
        public decimal CalcularArea()
        {
            return LadoA * LadoB;
        }
        public decimal CalcularPerimetro()
        {
            return LadoA * 2 + LadoB * 2;
        }
    }
}

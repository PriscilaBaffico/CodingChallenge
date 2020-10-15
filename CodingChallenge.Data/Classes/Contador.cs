
namespace CodingChallenge.Data.Classes
{
    public class Contador
    {
        public int NumeroFormas { get; set; }
        public decimal TotalArea { get; set; }
        public decimal TotalSuperficie { get; set; }
        public Contador()
        {
            NumeroFormas = 0;
            TotalArea = 0m;
            TotalSuperficie = 0m;
        }
    }
}

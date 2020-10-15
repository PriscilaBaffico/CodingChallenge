using System.Collections.Generic;

namespace CodingChallenge.Data.Classes
{
    public class Idiomas
    {
        public Dictionary<string, string> Ingles { get; private set; } = new Dictionary<string, string>
        {
            {"Cuadrado_Key", "Square" }, {"Circulo_Key", "Circle"}, {"Cuadrados_Key", "Squares"}, 
            {"Circulos_Key", "Circles"},{"Rectangulo_Key", "Rectangle" },
            {"Rectangulos_Key", "Rectangles" }, {"Trapecio_Key", "Trapeze" },
            {"Trapecios_Key", "Trapezoids" }, {"Triangulo_Key", "Triangle" },
            {"Triangulos_Key", "Triangles" }, {"Area_Key", "Area" }, {"Perimetro_Key", "Perimeter" }, 
            {"Total_Key", "Total" }, {"Formas_Key", "shapes" },
            {"Sin_Formas", "Empty list of shapes!" }, {"Inicio_Reporte", "Shapes report" }
        };
        public Dictionary<string, string> Frances { get; private set; } = new Dictionary<string, string>
        {
            {"Cuadrado_Key", "Carré" }, {"Circulo_Key", "Cercle"}, {"Cuadrados_Key", "Carrés" }, 
            {"Circulos_Key", "Cercles"}, {"Rectangulo_Key", "Rectangle" }, {"Rectangulos_Key", "Rectangles" }, 
            {"Trapecio_Key", "Trapèze" }, {"Trapecios_Key", "Trapèzes" }, {"Triangulos_Key", "Triangles" },
            {"Triangulo_Key", "Triangle" }, {"Area_Key", "la superficie" }, 
            {"Perimetro_Key", "Périmètre" }, {"Total_Key", "Total" }, {"Formas_Key", "formes" },
            {"Sin_Formas", "Liste vide de formes!" }, {"Inicio_Reporte", "Rapport sur les formes" }
        };
        public Dictionary<string, string> Castellano { get; private set; } = new Dictionary<string, string>
        {
            {"Cuadrado_Key", "Cuadrado" }, {"Circulo_Key", "Circulo"}, {"Cuadrados_Key", "Cuadrados" },
            {"Circulos_Key", "Circulos"}, {"Rectangulo_Key", "Rectangulo" },{"Rectangulos_Key", "Rectangulos" }, 
            {"Trapecio_Key", "Trapecio" }, {"Trapecios_Key", "Trapecios" }, {"Triangulos_Key", "Triangulos" },
            {"Triangulo_Key", "Triangulo" }, {"Area_Key", "Area" }, {"Perimetro_Key", "Perimetro" }, 
            {"Total_Key", "Total" }, {"Formas_Key", "formas" },
            {"Sin_Formas", "Lista vacía de formas!" }, {"Inicio_Reporte", "Reporte de Formas" }
        };
    }
}

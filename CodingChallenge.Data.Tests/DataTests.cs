using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Classes.Forms;
using CodingChallenge.Data.Enums;
using CodingChallenge.Data.Interfaces;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            //arrange
            var listaVacia = new List<IFormaGeometrica>();
            var idioma = EnumIdiomas.Castellano;
            //act
            string result = Reporte.Imprimir(listaVacia, idioma);
            //assert
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>", result);
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            //arrange
            var listaVacia = new List<IFormaGeometrica>();
            var idioma = EnumIdiomas.Ingles;
            //act
            string result = Reporte.Imprimir(listaVacia, idioma);
            //assert
            Assert.AreEqual("<h1>Empty list of shapes!</h1>", result);
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnFrances()
        {
            //arrange
            var listaVacia = new List<IFormaGeometrica>();
            var idioma = EnumIdiomas.Frances;
            //act
            string result = Reporte.Imprimir(listaVacia, idioma);
            //assert
            Assert.AreEqual("<h1>Liste vide de formes!</h1>", result);
        }
        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<IFormaGeometrica> {new Cuadrado(5)};
            var idioma = EnumIdiomas.Castellano;
            var resumen = Reporte.Imprimir(cuadrados, idioma);

            Assert.AreEqual("<h1>Reporte de Formas </h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };
            var idioma = EnumIdiomas.Ingles;
            var resumen = Reporte.Imprimir(cuadrados, idioma);

            Assert.AreEqual("<h1>Shapes report </h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnIngles()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var idioma = EnumIdiomas.Ingles;
            var resumen = Reporte.Imprimir(formas, idioma);

            Assert.AreEqual(
                "<h1>Shapes report </h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnFrances()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };
            var idioma = EnumIdiomas.Frances;
            var resumen = Reporte.Imprimir(formas, idioma);

            Assert.AreEqual(
                "<h1>Rapport sur les formes </h1>2 Carrés | la superficie 29 | Périmètre 28 <br/>2 Cercles | la superficie 13,01 | Périmètre 18,06 <br/>3 Triangles | la superficie 49,64 | Périmètre 51,6 <br/>TOTAL:<br/>7 formes Périmètre 97,66 la superficie 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var idioma = EnumIdiomas.Castellano;
            var resumen = Reporte.Imprimir(formas, idioma);

            Assert.AreEqual(
                "<h1>Reporte de Formas </h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Circulos | Area 13,01 | Perimetro 18,06 <br/>3 Triangulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrapecioEnFrances()
        {
            List<IFormaGeometrica> Trapecios = new List<IFormaGeometrica> { new Trapecio(5, 4, 3, 3.2m) };

            var idioma = EnumIdiomas.Frances;
            var resumen = Reporte.Imprimir(Trapecios, idioma);

            Assert.AreEqual("<h1>Rapport sur les formes </h1>1 Trapèze | la superficie 13,49 | Périmètre 15,2 <br/>TOTAL:<br/>1 formes Périmètre 15,2 la superficie 13,49", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasRectangulosEnIngles()
        {
            List<IFormaGeometrica> Rectangulos = new List<IFormaGeometrica> 
            { 
                new Rectangulo(5, 4),
                new Rectangulo(2, 3),
            };
            var idioma = EnumIdiomas.Ingles;
            var resumen = Reporte.Imprimir(Rectangulos, idioma);

            Assert.AreEqual("<h1>Shapes report </h1>2 Rectangles | Area 26 | Perimeter 28 <br/>TOTAL:<br/>2 shapes Perimeter 28 Area 26", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos2()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m),
                new Trapecio(5,3,2,2),
                new Rectangulo(5,3)
            };

            var idioma = EnumIdiomas.Frances;
            var resumen = Reporte.Imprimir(formas, idioma);

            Assert.AreEqual(
                "<h1>Rapport sur les formes </h1>2 Carrés | la superficie 29 | Périmètre 28 <br/>2 Cercles | la superficie 13,01 | Périmètre 18,06 <br/>3 Triangles | la superficie 49,64 | Périmètre 51,6 <br/>1 Trapèze | la superficie 6,93 | Périmètre 12 <br/>1 Rectangle | la superficie 15 | Périmètre 16 <br/>TOTAL:<br/>9 formes Périmètre 125,66 la superficie 113,58",
                resumen);
        }

    }
}

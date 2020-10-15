using CodingChallenge.Data.Enums;
using System.Collections.Generic;

namespace CodingChallenge.Data.Classes
{
    public class Traductor
    {
        public Idiomas Idioma { get; private set; } = new Idiomas();

        public string Traducir(EnumIdiomas idioma, string key)
        {
            try
            {
                switch (idioma)
                {
                    case EnumIdiomas.Ingles:
                        return Idioma.Ingles[key];
                    case EnumIdiomas.Castellano:
                        return Idioma.Castellano[key];
                    case EnumIdiomas.Frances:
                        return Idioma.Frances[key];
                    default:
                        return string.Empty;
                }
            }
            catch (KeyNotFoundException)
            {
                return string.Empty;
            }
        }
    }
}

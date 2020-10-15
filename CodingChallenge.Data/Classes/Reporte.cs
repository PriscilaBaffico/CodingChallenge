using CodingChallenge.Data.Enums;
using CodingChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class Reporte
    {
        public static string Imprimir(List<IFormaGeometrica> formas, EnumIdiomas idioma)
        {
            var sb = new StringBuilder();
            Traductor traductor = new Traductor();

            if (formas.Count == 0)
            {
                sb.Append("<h1>" + traductor.Traducir(idioma, "Sin_Formas") + "</h1>");
            }
            else
            {
                sb.Append("<h1>" + traductor.Traducir(idioma, "Inicio_Reporte") + " </h1>");
                bool esPlural = formas.Count > 1;

                //Body
                Dictionary<EnumFormas, Contador> DiccionarioContador = LlenarDiccionario(formas);
                bool hayMasDeUno;

                foreach (EnumFormas item in DiccionarioContador.Keys.ToList())
                {
                    hayMasDeUno = DiccionarioContador[item].NumeroFormas > 1;
                    string formaKey = formas.First(x => x.Tipo == item).obtenerKey(hayMasDeUno);
                    sb.Append($"{DiccionarioContador[item].NumeroFormas} {traductor.Traducir(idioma, formaKey)} | " + traductor.Traducir(idioma, "Area_Key") + $" {DiccionarioContador[item].TotalArea:#.##} | " + traductor.Traducir(idioma, "Perimetro_Key") + $" {DiccionarioContador[item].TotalSuperficie:#.##} <br/>");
                }

                //footer
                sb.Append(traductor.Traducir(idioma, "Total_Key").ToUpper() + ":<br/>");
                sb.Append(formas.Count().ToString() + " " + traductor.Traducir(idioma, "Formas_Key") + " ");
                sb.Append(traductor.Traducir(idioma, "Perimetro_Key") + " " + DiccionarioContador.Values.Sum(x => x.TotalSuperficie).ToString("#.##") + " ");
                sb.Append(traductor.Traducir(idioma, "Area_Key") + " " + DiccionarioContador.Values.Sum(x => x.TotalArea).ToString("#.##"));
            }
            return sb.ToString();

        }

        private static Dictionary<EnumFormas, Contador> LlenarDiccionario(List<IFormaGeometrica> formas)
        {
            Dictionary<EnumFormas, Contador> DiccionarioContador = new Dictionary<EnumFormas, Contador>();

            for (var i = 0; i < formas.Count; i++)
            {
                if (DiccionarioContador.ContainsKey(formas[i].Tipo))
                {
                    DiccionarioContador[formas[i].Tipo].NumeroFormas += 1;
                    DiccionarioContador[formas[i].Tipo].TotalArea += formas[i].CalcularArea();
                    DiccionarioContador[formas[i].Tipo]. TotalSuperficie += formas[i].CalcularPerimetro();
                }
                else
                {
                    DiccionarioContador.Add(formas[i].Tipo, new Contador()
                    {
                        NumeroFormas = 1,
                        TotalArea = formas[i].CalcularArea(),
                        TotalSuperficie = formas[i].CalcularPerimetro()
                    });
                }
            }
            return DiccionarioContador;       
        }

    }
}

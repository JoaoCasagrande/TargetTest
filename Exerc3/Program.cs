using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.Json;

namespace Exerc3
{
    public class Dados 
    {
        public int dia {get;set;}
        public double valor {get;set;}
    }

    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"./dados.json");
            var dadosLista = JsonSerializer.Deserialize<List<Dados>>(text);
            dadosLista.RemoveAll(d => d.valor <= 0);

            double media = 0, lowest = dadosLista[0].valor, highest = dadosLista[0].valor;
            int contador = 0;

            foreach(Dados d in dadosLista) {
                media += d.valor;

                if (d.valor <= lowest) lowest = d.valor;
                else if (d.valor >= highest) highest = d.valor;
            }
            media = media / dadosLista.Count;

            foreach(Dados d in dadosLista) {
                if (d.valor > media) contador++;
            }

            Console.WriteLine("Menor valor de faturamento: " + lowest.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine("Maior valor de faturamento: " + highest.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine("Número de dias no mês em que o valor de faturamento diário foi superior à média mensal: " + contador);
        }
    }
}
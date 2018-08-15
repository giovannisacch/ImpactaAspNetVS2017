using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace AspNetVS2017.Capitulo01.VetoresColecoes.Testes
{
    [TestClass]
    public class ColecoesTeste
    {
        [TestMethod]
        public void ListTeste()
        {
            var inteiros = new List<int>();

            inteiros.Add(2);
            inteiros.Add(0);
            inteiros.Add(4);
            inteiros.Add(8);

            //inteiros[10] = 51;

            var maisInteiros = new List<int> {2, 1, 0, 20};
            inteiros.AddRange(maisInteiros);

            inteiros.Insert(0, 21); //Nãu substitui o valor, toma a posição e empurra o resto(Posição e valor)
            
            inteiros.Remove(5); //Remove elemento de valor 5, não da posição.

            inteiros.RemoveAt(0); //Remove elemento da posição indicada
            inteiros.Sort(); //

            var primeiro = inteiros.First();//inteiros[0]
            var ultimo = inteiros.Last();//[inteiros.Count - 1]

            foreach (var inteiro in inteiros)
            {
                Console.WriteLine($"Indíce: {inteiros.IndexOf(inteiro)} valor: {inteiro}");
            }
        }
        [TestMethod]
        public void DictionaryTeste()
        {
            var feriados = new Dictionary<DateTime, string>();
            feriados.Add(new DateTime(2018, 12,25), "Natal");
            feriados.Add(new DateTime(2019, 1, 1), "Ano novo");
            feriados.Add(new DateTime(2019, 1, 25), "Aniversario de São Paulo");

            //feriados.Add(new DateTime(2018, 12, 25), "Natal");

            var natal = feriados[Convert.ToDateTime("25/12/2018")];
            foreach (var feriado in feriados)
            {
                Console.WriteLine($"{feriado.Key.ToString("dd/MM/yyyy")}: {feriado.Value}");
            }
            Console.WriteLine(feriados.ContainsKey(Convert.ToDateTime("25/12/2018")));
            Console.WriteLine(feriados.ContainsValue("Ano novo"));

        }
    }
}

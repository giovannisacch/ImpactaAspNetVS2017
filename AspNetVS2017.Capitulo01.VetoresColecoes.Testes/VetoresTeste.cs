﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNetVS2017.Capitulo01.VetoresColecoes.Testes
{
    [TestClass]
    public class VetoresTeste
    {
        [TestMethod]
        public void InicializacaoTeste()
        {
            var strings = new string[10];
            int[] inteiros = new int[5];
            inteiros[0] = 9;
            inteiros[4] = 2;

            var decimais = new decimal[3] {0.3m, 0.2m, 7m};

            decimal[] outroVetor = { 0.5m, 8.6m, 12 };

            foreach (var @decimal in decimais)
            {
                Console.WriteLine(@decimal);
            }
            Console.WriteLine("Tamanho do vetor: " + decimais.Length);
        }
        [TestMethod]
        public void RedimensionamentoTeste()
        {
            var decimais = new decimal[] { 3.1m, 9.3m, 10 };

            Array.Resize(ref decimais, 5);

            decimais[4] = 1.8m;
        }
        [TestMethod]
        public void OrdenacaoTeste()
        {
            var decimais = new decimal[] { 3.1m, 9m, 1.3m };

            Array.Sort(decimais);

            Assert.AreEqual(decimais[0], 1.3m);
        }
        [TestMethod]
        public void ParamsTeste()
        {
            Console.WriteLine(Media(3, 0.89m, 4, 0.50m));
        }
        [TestMethod]
        public void TodaStringEhUmVetorTeste()
        {
            //StringBuilder
            var nome = "Hejlsberg";
            Assert.AreEqual(nome[0], 'H');

            foreach (var letra in nome)
            {
                Console.Write(letra);
            }
        }

        private decimal Media(decimal num1, decimal num2)
        {
            //decimal media;
            //media = (num1 + num2) / 2;
            //return media;
            return (num1 + num2) / 2;
        }

        private decimal Media(params decimal[] decimais)
        {
            //return decimais.Average();
            decimal soma = 0;
            //var qtde = decimais.Length;
            foreach (var numero in decimais)
            { 
                soma += numero;
            }
            return soma / decimais.Length;
        }
    }
}

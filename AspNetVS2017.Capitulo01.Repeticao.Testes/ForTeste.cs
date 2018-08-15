using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNetVS2017.Capitulo01.Repeticao.Testes
{
    [TestClass]
    public class ForTeste
    {
        [TestMethod]
        public void TabuadaTeste()
        {
            int x = 1;
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{x} * {i} = {(i * x)}");
                if (i == 10 && x < 10)
                {
                    x++;
                    i = 0;
                    Console.Write(new string('-', 100));
                };
                //for (int j = 1; j <= 10; j++)
                //{
                //    Console.WriteLine($"{i} * {j} = {(i * j)}");
                //}

                //Console.Write(new string('-', 100));
            }
        }
        [TestMethod]
        public void EstruturaForTeste()
        {
            var i = 1;

            for (Console.WriteLine("Iniciou"); i <= 3; Console.WriteLine(i))
            {
                i++;
            }
            /* 
             for ('.inicialização; 2.condição; 4. pós-execução)
             {
                3.execução;
             }
             */
        }
        [TestMethod]
        public void ForApenasComCondicaoTeste()
        {
            var i = 1;
            for (; i <= 3;)
            {
                Console.WriteLine(i++);
            }
        }
        [TestMethod]
        public void ContinueTeste()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i <= 5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
        [TestMethod]
        public void BreakTeste()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i > 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}

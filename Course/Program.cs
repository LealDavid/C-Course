using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            DateTime d2 = DateTime.Parse("15/08/2021  07:43:54");

            TimeSpan dif = d2.Subtract(d1);
            Console.WriteLine(dif);
            string duracao = dif.ToString();
            Console.WriteLine(duracao);
            Console.WriteLine(duracao.Substring(0,3) + "days\n" + duracao.Substring(4,2) + "hours");

            double tempo = 2.12;
            TimeSpan t = TimeSpan.Parse("2");
            int a = 10;
            Console.WriteLine(t);
            TimeSpan soma = new TimeSpan(0, a, 15, 26);
            Console.WriteLine(soma);
        }
    }
}
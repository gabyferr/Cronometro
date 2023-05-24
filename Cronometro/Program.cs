using System;
using System.Threading;

namespace Cronometro
{
    class Programan
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu() 
        {
            Console.Clear();
            Console.WriteLine("menu");
            Console.WriteLine("S = Segundos => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            //Console.WriteLine(data);
            //Console.WriteLine(type);
            //Console.WriteLine(time);

            if (type == 'm')
            {
                multiplier = 60;
            }
            if (time == 0)
            {
                System.Environment.Exit(0);
            }
            PreStart(time + multiplier);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready......");
            Thread.Sleep(1000);
            Console.WriteLine("Set.....");
            Thread.Sleep(1000);
            Console.WriteLine("Go........");
            Thread.Sleep(2500);

            Start(time);
        }

        static void Start(int time)
        {
            //int time = 10;
            int currentTime = 0;

            while(currentTime != time)
            {
                Console.Clear();
                currentTime ++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2500);
            Menu();
        }
    }
}
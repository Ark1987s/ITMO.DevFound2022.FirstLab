using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] arg)
        {
            Console.WriteLine("Вы готовы сегодня выполнить пробежку? ('y' = да)");
            string run = Console.ReadLine();
            if (run == "y")
            {
                var current_time = DateTime.Now.TimeOfDay;
                var limit_time = new TimeSpan(21, 00, 0);
            compare:
                if (current_time <= limit_time)
                {
                    Console.WriteLine("\nВы готовы к пробежке сейчас? ('y' = да)");
                    string ready = Console.ReadLine();

                    if (ready == "y")
                    {
                        Console.WriteLine("\nОтлично! Вперёд!");
                        // запуск видеопроигрывателя для демонстрации упражнений разминки 
                    }
                    else
                    {
                        Console.WriteLine("\nОжидайте напоминание через час!");
                        int time = 60 * 60 * 1000;
                        Thread.Sleep(time);
                        goto compare;
                    }

                }
                else
                {
                    Console.WriteLine("\nОтдохните! Сегодня уже поздно!");
                    Console.WriteLine("\nДо завтра!");
                }

            }
            else
            {
                Console.WriteLine("\nВыполните упражнения - приседания!");
                int n = 10;
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("i=" + i);
                    Thread.Sleep(2000);

                }

                Console.WriteLine("\nУпражнения выполнены!");
                Console.WriteLine("\nДо завтра!");

            }
            Console.Read();
        }
    }
}
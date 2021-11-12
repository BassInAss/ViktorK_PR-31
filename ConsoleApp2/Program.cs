using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] razn = new double[3];
            string numbers = "1234567890";
            bool yesno = false;
            Console.WriteLine("Введите число");
            for (int i = 0; i < 3; i++)
            {
                string temp = Console.ReadLine();
                if (numbers.Contains(temp))
                {
                    razn[i] = Convert.ToDouble(temp);
                }
                else
                {
                    yesno = true;
                    Console.WriteLine("Введено не число");
                    break;
                }
            }
            if (yesno == false)
            {
                Console.WriteLine(razn.Aggregate((x, y) => x - y));
            } 
        }
    }
}

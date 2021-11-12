using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp1
{
    public class Guys
    {
            static void Main(string[] args)
            {
                StreamWriter sw = new StreamWriter("text.txt");
                sw.WriteLine("Иванов Сергей Николаевич 21 64");
                sw.WriteLine("Петров Игорь Юрьевич 45 88");
                sw.WriteLine("Семёнов Михаил Алексеевич 20 70");
                sw.WriteLine("Пиманов А");
                sw.Close();

                List<string[]> people = new List<string[]>();
                StreamReader sr = new StreamReader("text.txt");

                while (!sr.EndOfStream)
                {
                    string temp = sr.ReadLine();
                    people.Add(temp.Split(' '));
                }
                try
                {
                    var func = people.Where(q => int.Parse(q[3]) % 3 == 0);
                    foreach (string[] q in func)
                    {
                        Console.WriteLine(string.Join(" ", q));

                    }
                }
                catch 
                { 
                Console.WriteLine("Персона имеет неверные параметры"); 
                }
                Console.WriteLine();
                Console.WriteLine("Конец программы");
            }  
    }
}


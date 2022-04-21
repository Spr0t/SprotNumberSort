using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {


        static void Main(string[] args)
        {

            Console.WriteLine("Введите кол-во случайных чисел: ");
            int go = int.Parse(Console.ReadLine());
            NumbersSort n = new NumbersSort(go);
            n.GenerateNumbers();
            n.Sort();
            n.DrawSorted();
            Console.ReadLine();

        }
    }





    
}

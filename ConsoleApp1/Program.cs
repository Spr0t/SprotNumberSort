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

            NumbersSort v = new NumbersSort();
            v.NumbersValue();
            v.Print();
            v.SortMinToMax();
            Console.WriteLine("Отсортированый массив:");
            v.Print();
            v.AvarageOfAll();
            Console.WriteLine($"Среднее значение всех элементов в массиве: {v.AvarageofAll}");
            Console.WriteLine($"Минимальное значение: {v.Min}");
            Console.WriteLine($"Максимальное значение: {v.Max}");


            Console.ReadLine();

        }
    }





    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class NumbersSort
    {

        public int[] Numbers { get; set; }
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public int AvarageValue { get; set; }
        public int AvarageofAll { get; set; }
        public int Min { get; set; }

        public int Max { get; set; }

        public void NumbersValue()
        {
            int numbersLength;
            Console.WriteLine("Напишите количество элементов в массиве, который хотите заполнить случайными числами:");
            try
            {
                numbersLength = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                throw new ArgumentException("Ошибка корректности ввода!");
            }


            int[] numbers = new int[numbersLength];
            for (int i = 0; i < numbers.Length; i++)
            {
                var rnd = new Random(i);
                numbers[i] = rnd.Next(1, 100);
            }
            Console.WriteLine($"Массив длиной {numbersLength} значений создан.");

            Numbers = numbers;
        }

        public void SortMinToMax()
        {
            for (int i = 0; i < Numbers.Length - 1; i++)
            {
                int min;
                //Numbers[i] = 10
                //Numbers[j] = 5

                for (int j = i + 1; j < Numbers.Length; j++)
                {
                    if (Numbers[i] > Numbers[j])
                    {
                        min = Numbers[i];
                        Numbers[i] = Numbers[j];
                        Numbers[j] = min;
                    }
                }
                Min = Numbers[0];
                Max = Numbers[Numbers.Length-1];
            }
        }


        public void AvarageOfAll()
        {
            int result = 0;
            for (int i = 0; i < Numbers.Length; i++)
            {
               
                result += Numbers[i];

            }
            AvarageofAll = result / Numbers.Length;
        }

        public void Print()
        {
            int count=1;
            foreach (var item in Numbers)
            {
                Console.WriteLine($" Число {count} - {item} ");
                count++;
            }
        }


    }
}

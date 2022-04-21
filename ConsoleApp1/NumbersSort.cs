using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class NumbersSort
    { 

        public  List<int> Numbers { get; set; }
        public int Count { get; set ;}

        public NumbersSort(int Count)
        {
            this.Count = Count;
        }


        public void GenerateNumbers()
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < Count; i++)
            {
                Random rnd = new Random(i);
                int x = rnd.Next(0, 100);
                numbers.Add(x);
            }  
            this.Numbers = numbers;
        }
        public void Sort()
        {
            int swap;

            for (int i = 0;i <Count - 1;i++)
            {
                for (int j = i + 1; j < Count; j++)
                {
                    if (Numbers[i] > Numbers[j])
                    {
                        swap = Numbers[i];
                        Numbers[i] = Numbers[j];
                        Numbers[j] = swap;
                    }
                }
            }
        }


        public void DrawSorted()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine($"Отсортировано : {Numbers[i]}");
            }
        }

    }
}

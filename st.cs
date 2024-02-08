using _3_2improved;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2improved
{
    public sealed class SteppedArr : Base
    {
        public int[][] array;
        public int[] lengths = new int[100];
        Random rnd = new Random();
        //public bool WayOfInputtingTheArray = false;
        public SteppedArr()
        {
            Console.WriteLine("Ступенчатые  массивы");
            Console.WriteLine("Введите количество строк");
            int colN = int.Parse(Console.ReadLine());
            array = new int[colN][];
            int[] lengths = new int[colN];
            for (int i = 0; i < colN; i++)
            {
                Console.WriteLine("Сколько элементов в строке " + (i + 1) + "?");
                lengths[i] = int.Parse(Console.ReadLine());
                array[i] = new int[lengths[i]];
            }
            Console.WriteLine("Хотите сами ввести массив? + = да, - = нет");
            if (Console.ReadLine() == "+")
            {
                UserFill();
            }
            else
            {
                RandFill();
            }
        }

        public override void Initializ()
        {
            Console.WriteLine("Ступенчатые  массивы");
            Console.WriteLine("Введите количество строк");
            int colN = int.Parse(Console.ReadLine());
            array = new int[colN][];
            int[] lengths = new int[100];
            for (int i = 0; i < colN; i++)
            {
                Console.WriteLine("Сколько элементов в строке " + (i + 1) + "?");
                lengths[i] = int.Parse(Console.ReadLine());
                array[i] = new int[lengths[i]];
            }
            Console.WriteLine("Хотите сами ввести массив? + = да, - = нет");
            if (Console.ReadLine() == "+")
            {
                UserFill();
            }
            else
            {
                RandFill();
            }
        }

        public override void countAverage()
        {
            Console.WriteLine("Среднее значение в ступенчатом массиве:");
            int m = 0;
            int num = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    m += array[i][j];
                    num++;
                }
            }
            Console.WriteLine(m / num);
        }

        public override void Output()
        {
            Console.WriteLine("Ступенчатый массив:");
            for (int i = 0; i < array.Length; i++)
            {
                int lineM = array[i].Length;
                for (int j = 0; j < lineM; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public override void UserFill()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите элементы строки " + (i + 1));
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = int.Parse(Console.ReadLine());
                }

            }
        }

        public override void RandFill()
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = rnd.Next(-100, 100);
                }
            }
        }
    }
}



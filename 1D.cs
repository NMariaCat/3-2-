using _3_2improved;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2improved
{
    public sealed class OneDimentionArr : Base
    {
        private int[] array;
        Random rnd = new Random();
        public OneDimentionArr()
        {
            Console.WriteLine("Одномерные  массивы");
            Console.WriteLine("Введите количество элементов.");
            int ElementsNumber = int.Parse(Console.ReadLine());
            array = new int[ElementsNumber];
            Console.WriteLine("Хотите сами ввести массив? + = да, - = нет");
            //bool WayInpArr1D;

            if (Console.ReadLine() == "+")
            {
                UserFill();
            }
            else
            {
                RandFill();
            }
        }

        public override void UserFill()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        public override void RandFill()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-100, 100);
            }
        }

        public override void Initializ()
        {
            Console.WriteLine("Одномерные  массивы");
            Console.WriteLine("Введите количество элементов.");
            int ElementsNumber = int.Parse(Console.ReadLine());
            array = new int[ElementsNumber];
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

        public override void Output()
        {
            Console.WriteLine("Одномерный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public override void countAverage()
        {
            Console.WriteLine("Среднее значение в одномерном массиве:");
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                k += array[i];
            }
            Console.WriteLine(k / array.Length); ;
        }
    }
}


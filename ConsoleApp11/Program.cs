using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1.Определить, имеются ли в одномерном массиве случайных чисел элементы, значения которых кратны 11.Вывести такие значения.
            //int[] omas = new int[10];
            //Console.Write("zpolni");
            //for(int i = 0; i < omas.Length;i++)
            //{
            //    Console.WriteLine($"omas [{i}] = ");
            //    omas[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //foreach(int e in omas)
            //{
            //    int x = (e % 11 == 0) ? e:'2';
            //    Console.Write(x);
            //}
            //Console.ReadKey();

            //Задача 2 Найти сумму и количество положительных элементов в одномерном массиве с явной инициализацией.
            //int[] omas = new int[] { 5, -4, 8, 7, -2 };
            //int value = 0;
            //int count = 0;
            //for (int i = 0; i < omas.Length; i++)
            //{
            //    if (omas[i] > 0)
            //    {
            //        value += omas[i];
            //        count++;

            //    }
            //}
            //Console.WriteLine($"Сумма: {value}\n колво:{count}");
            //Console.ReadKey();

            //Задача 3.Вывести элементы одномерного массива, заполненного с клавиатуры ,в обратном порядке.
            //const int n = 6;
            //int[] mass = new int[n];
            //Random rng = new Random();
            //for(int i = 0; i<mass.Length; i++)
            //{
            //    mass[i] = rng.Next(0, 99);
            //    Console.WriteLine($"omas[{i}] = {mass[i]}");
            //}
            //for (int i = mass.Length - 1; i > mass.Length; i--)
            //{
            //    Console.WriteLine(mass[i]);
            //}
            //Console.ReadKey();
        }
    }
}

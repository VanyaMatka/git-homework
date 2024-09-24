using System;

namespace GitHomework
{
    class Program
    {
        static void Main(string args)
        {
            Console.WriteLine("������� �����:");
            double number = Convert.ToDouble(Console.ReadLine());
            double cube = CalculateCube(number);
            Console.WriteLine($"��� ����� {number} ����� {cube}");
        }

        static double CalculateCube(double num)
        {
            return Math.Pow(num, 3);
        }
        static double CalculateCubeDouble(double num)
        {
            return num * num * num;
        }

    }
}
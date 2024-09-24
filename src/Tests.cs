using System;

namespace GitHomework
{
    class Tests
    {
        static void Main(string[] args)
        {
            TestCalculateCube();
        }

        static void TestCalculateCube()
        {
            RunTest(3, 27);
            RunTest(4, 64);
        }

        static void RunTest(int input, int expected)
        {
            int result = Program.Cube(input);
            if (result == expected)
            {
                Console.WriteLine($"���� �������: Cube({input}) = {result}. ��������: {expected}");
            }
            else
            {
                Console.WriteLine($"���� ��������: Cube({input}) = {result}. ��������: {expected}");
            }
        }
    }
}

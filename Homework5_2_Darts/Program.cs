using System;
namespace Homework5_2_Darts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Tuple<int, int>> points = new List<Tuple<int, int>>();
            Tuple<int, int> point;
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                point = Tuple.Create(rnd.Next(-100, 100), rnd.Next(-100, 100));
                points.Add(point);
            }

            int score = 0;
            int Xo = 0, Yo = 0;
            int r1 = 10, r2 = 20, r3 = 30, r4 = 40, r5 = 50, r6 = 60, r7 = 70,
                r8 = 80, r9 = 90, r10 = 100;

            foreach (Tuple<int, int> p in points)
            {
                int x = p.Item1;
                int y = p.Item2;
                int coordinates = (x - Xo) * (x - Xo) + (y - Yo) * (y - Yo);
                Console.WriteLine($"Point ({x}, {y})");
                if (coordinates <= r1 * r1)
                {
                    score += 10;
                    Console.WriteLine($"+ 10 points");
                }
                else if (coordinates <= r2 * r2)
                {
                    score += 9;
                    Console.WriteLine($"+ 9 points");
                }
                else if (coordinates <= r3 * r3)
                {
                    score += 8;
                    Console.WriteLine($"+ 8 points");
                }
                else if (coordinates <= r4 * r4)
                {
                    score += 7;
                    Console.WriteLine($"+ 7 points");
                }
                else if (coordinates <= r5 * r5)
                {
                    score += 6;
                    Console.WriteLine($"+ 6 points");
                }
                else if (coordinates <= r6 * r6)
                {
                    score += 5;
                    Console.WriteLine($"+ 5 points");
                }
                else if (coordinates <= r7 * r7)
                {
                    score += 4;
                    Console.WriteLine($"+ 4 points");
                }
                else if (coordinates <= r8 * r8)
                {
                    score += 3;
                    Console.WriteLine($"+ 3 points");
                }
                else if (coordinates <= r9 * r9)
                {
                    score += 2;
                    Console.WriteLine($"+ 2 points");
                }
                else if (coordinates <= r10 * r10)
                {
                    score += 1;
                    Console.WriteLine($"+ 1 point");
                }
                else
                {
                    Console.WriteLine($"0 points");
                }
            }
            Console.WriteLine($"Your total score is {score}");
            Console.ReadKey();
        }
    }
}


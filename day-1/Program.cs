//problem 1: nyari nilai terbesar dari jumlah lines per  (dipisah pake \n)
//problem 2: nyari jumlah dari 3 nilai terbesar dari tiap set lines
using System;

namespace day1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] biggestTotal = { 0, 0, 0 };
            int buffer, totals, currentNumber;
            int sum = 0;
            string[] lines = System.IO.File.ReadAllLines("input.txt");
            foreach (string line in lines)
            {
                if (line.Length > 0)
                {
                    currentNumber = int.Parse(line);
                    sum = sum + currentNumber;
                }
                else
                {
                    if (sum > biggestTotal[2])
                    {
                        biggestTotal[2] = sum;
                        if (biggestTotal[2] > biggestTotal[1])
                        {
                            buffer = biggestTotal[1];
                            biggestTotal[1] = biggestTotal[2];
                            biggestTotal[2] = buffer;
                            if (biggestTotal[1] > biggestTotal[0])
                            {
                                buffer = biggestTotal[0];
                                biggestTotal[0] = biggestTotal[1];
                                biggestTotal[1] = buffer;
                            }
                        }
                    }
                    sum = 0;
                }
            }
            totals = biggestTotal[0] + biggestTotal[1] + biggestTotal[2];
            Console.WriteLine("Problem-1: " + biggestTotal[0]);
            Console.WriteLine("Problem-2: " + totals);
        }
    }
}

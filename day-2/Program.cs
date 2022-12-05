using System;

namespace day_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = { 'A', 'B', 'C', 'X', 'Y', 'Z' };
            int lineScore = 0;
            int realScore = 0;
            string letter = new string(letters);
            string[] lines = System.IO.File.ReadAllLines("input.txt");
            foreach (string line in lines)
            {
                if (line[0] == letter[0])
                {
                    if (line[2] == letter[3])
                    {
                        //a x
                        lineScore = lineScore + 4;
                        realScore = realScore + 3;
                    }
                    else if (line[2] == letter[4])
                    {
                        //a y
                        lineScore = lineScore + 8;
                        realScore = realScore + 3 + 1;

                    }
                    else
                    {
                        //a z
                        lineScore = lineScore + 3;
                        realScore = realScore + 6 + 2;

                    }
                }
                else if (line[0] == letter[1])
                {
                    if (line[2] == letter[3])
                    {
                        //b x
                        lineScore = lineScore + 1;
                        realScore = realScore + 1;


                    }
                    else if (line[2] == letter[4])
                    {
                        //b y
                        lineScore = lineScore + 2 + 3;
                        realScore = realScore + 3 + 2;

                    }
                    else
                    {
                        //b z
                        lineScore = lineScore + 3 + 6;
                        realScore = realScore + 6 + 3;

                    }
                }
                else if (line[0] == letter[2])
                {
                    if (line[2] == letter[3])
                    {
                        //c x
                        lineScore = lineScore + 1 + 6;
                        realScore = realScore + 2;

                    }
                    else if (line[2] == letter[4])
                    {
                        //c y
                        lineScore = lineScore + 2;
                        realScore = realScore + 3 + 3;

                    }
                    else
                    {
                        //c z
                        lineScore = lineScore + 3 + 3;
                        realScore = realScore + 6 + 1;

                    }
                }
            }
            Console.WriteLine("Problem 1: " + lineScore);
            Console.WriteLine("Problem 2: " + realScore);
        }
    }
}

//x kalah
//y draw
//z menang
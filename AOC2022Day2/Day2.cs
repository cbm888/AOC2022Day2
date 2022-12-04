using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2022Day2
{
    public class Day2
    {
        string[] day2Data = File.ReadAllLines("day2.txt");

        public void Solutions()
        {
            int score = 0;
            int score2 = 0;

            foreach (string s in day2Data)
            {
                string[] moves = s.Split(' ');

                if (moves[0] == "A")
                {
                    switch (moves[1])
                    {
                        case "X":
                            score += (1 + 3);
                            score2 += 3;
                            break;
                        case "Y":
                            score += (2 + 6);
                            score2 += (1 + 3);
                            break;
                        case "Z":
                            score += 3;
                            score2 += (2 + 6);
                            break;
                    }
                }
                if (moves[0] == "B")
                {
                    switch (moves[1])
                    {
                        case "Y":
                            score += (2 + 3);
                            score2 += (2 + 3);
                            break;
                        case "Z":
                            score += (3 + 6);
                            score2 += (3 + 6);
                            break;
                        case "X":
                            score += 1;
                            score2 += 1;
                            break;
                    }
                }
                if (moves[0] == "C")
                {
                    switch (moves[1])
                    {
                        case "Z":
                            score += (3 + 3);
                            score2 += (1 + 6);
                            break;
                        case "X":
                            score += (1 + 6);
                            score2 += 2;
                            break;
                        case "Y":
                            score += 2;
                            score2 += (3 + 3);
                            break;
                    }
                }

            }

            Console.WriteLine("Part 1: {0}", score);
            Console.WriteLine("Part 2: {0}", score2);
        }
    }
}

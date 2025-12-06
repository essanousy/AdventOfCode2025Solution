namespace AdventOfCode2025Solution.Day1
{
    public static class SolutionDay1
    {
        public static int Solve()
        {
            int solution = 0;
            string[] inputLines = System.IO.File.ReadAllLines("Day1/Input.txt");
            int dialPosition = 50;
            int start = 0;
            int end = 99;
            Console.WriteLine($"The dial starts by pointing at {dialPosition}");
            foreach (var line in inputLines)
            {

                string rotation = line.Substring(0, 1);
                int length = int.Parse(line.Substring(1));
                
                if (rotation == "L")
                {
                   for (int i = 0; i < length; i++)
                   {
                        dialPosition--;
                        if (dialPosition < start) dialPosition = end;
                   }

                }
                else if (rotation == "R")
                {
                     for (int i = 0; i < length; i++)
                    {
                        dialPosition++;
                        if (dialPosition > end) dialPosition = start;
                    }
                }

                if (dialPosition == 0)
                {
                    solution++;
                }

                Console.WriteLine($"The dial is rotated {line} to point at {dialPosition}");
            }

            return solution;
        }
    }
}

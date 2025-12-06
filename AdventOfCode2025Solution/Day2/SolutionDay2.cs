namespace AdventOfCode2025Solution.Day2;

public static class SolutionDay2
{
    public static long Solve()
    {
        long solution = 0;
        string[] inputLines = System.IO.File.ReadAllLines("Day2/Input.txt");
        string[] inputValues = inputLines[0].Split(',');
        foreach (var input in inputValues)
        {
            Console.WriteLine($"Processing input value: {input}");
            long start = long.Parse(input.Substring(0, input.IndexOf('-')));
            long end = long.Parse(input.Substring(input.IndexOf('-') + 1));
            for (long number = start; number <= end; number++)
            {
                var numberStr = number.ToString();
                var numberlength = numberStr.Length;
                if (numberlength % 2 == 0)
                {
                    var firstHalf = numberStr.Substring(0, numberlength / 2);
                    var secondHalf = numberStr.Substring(numberlength / 2);
                    if (firstHalf == secondHalf)
                    {
                        Console.WriteLine($"Found invalid ID : {number}");
                        solution += number;
                    }
                }
            }
        }
        return solution;
    }
}


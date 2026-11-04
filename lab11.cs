using System;

class Program
{
    static void Main(string[] args)
    {
        int[] grades = { 75, 90, 45, 60, 85, 30, 95, 70 };

        Console.WriteLine(CalculateAverage(70, 90));
        Console.WriteLine(CalculateAverage(60, 75, 90));
        Console.WriteLine(CalculateAverage(grades));
    }

    static double CalculateAverage(int grade1, int grade2)
    {
        return (grade1 + grade2) / 2.0;
    }

    static double CalculateAverage(int grade1, int grade2, int grade3)
    {
        return (grade1 + grade2 + grade3) / 3.0;
    }

    static double CalculateAverage(int[] grades)
    {
        int total = 0;

        foreach (int grade in grades)
        {
            total += grade;
        }

        return (double)total / grades.Length;
    }
}

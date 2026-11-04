using System;

int[] grades = { 75, 90, 45, 60, 85, 30, 95, 70 };

Console.WriteLine(CalculateTotal(10, 20));
Console.WriteLine(CalculateTotal(10, 20, 30));
Console.WriteLine(CalculateTotal(grades));
Console.WriteLine(CalculateTotal());

static int CalculateTotal(params int[] grades)
{
    int total = 0;
    for (int i = 0; i < grades.Length; i++)
        total += grades[i];
    return total;
}

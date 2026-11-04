int[] grade = { 75, 90, 45, 60, 85, 30, 95, 70 };
double aver = CalculateAverage(grade);
int Max = FindMaxnum(grade);
int Min = FindMinnum(grade);

Console.WriteLine($"Average : {aver} ");
Console.WriteLine($"FindMaxnum : {Max}  ");
Console.WriteLine($"Find Min num : {Min} ");
static double CalculateAverage(int[] grade)
{
    int sum = 0;
    for (int i = 0; i < grade.Length; i++)
    {
        sum += grade[i];
    }
    double average = (double)sum / grade.Length;
    return average;

}

static int FindMaxnum(int[] grade)
{
    int max = grade[0];

    for (int i = 0; i < grade.Length; i++)
    {
        if (grade[i] > max)
        {
            max = grade[i];
        }
    }
    return max;

}

static int FindMinnum(int[] grade)
{
    int min = grade[0];
    for (int i = 0; i < grade.Length; i++)
    {
        if (grade[i] < min)
        {
            min = grade[i];
        }
    }
    return min;
}

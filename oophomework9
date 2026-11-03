double[] week = { 14.2, 17.5, 19.0, 16.8, 21.3, 22.7, 18.4 };

double sum = 0;

for (int i = 0; i < week.Length; i++)
{
    sum += week[i];
}

double avg = sum / week.Length;

Console.WriteLine("Ortalama: " + avg);

double max = week[0];
int day = 1;

for (int i = 0; i < week.Length; i++)
{
    if (week[i] > max)
    {
        max = week[i];
        day = i + 1;
    }
}

Console.WriteLine("En sıcak gün: " + day + ". gün");
Console.WriteLine("En yüksek sıcaklık: " + max);

Console.WriteLine("Ortalamadan sıcak günler:");

for (int i = 0; i < week.Length; i++)
{
    if (week[i] > avg)
    {
        Console.WriteLine((i + 1) + ". gün: " + week[i]);
    }
}

Console.WriteLine("Son üç gün:");

for (int i = 4; i < 7; i++)
{
    Console.WriteLine(week[i]);
}

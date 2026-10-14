using System;

double sum = 0;
int count = 0;
double input;

Console.WriteLine("Sayıları girin (Hesaplamak ve bitirmek için 0 yazın):");

while (true)
{
    Console.Write("Sayı: ");
    input = Convert.ToDouble(Console.ReadLine());

    
    if (input == 0)
    {
        break;
    }

    sum += input;
    count++;
}

Console.WriteLine("\n--- Sonuçlar ---");
Console.WriteLine("Girilen Sayı Adeti (count): " + count);
Console.WriteLine("Toplam Değer (sum): " + sum);

if (count > 0)
{
    double average = sum / count;
    Console.WriteLine("Ortalama: " + average);
}
else
{
    Console.WriteLine("Hiç sayı girilmediği için ortalama hesaplanamadı.");
}

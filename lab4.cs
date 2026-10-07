Console.Write("Enter a 3-digit number: ");
int sayi = int.Parse(Console.ReadLine());
int yuzler = sayi / 100;
int onlar = (sayi / 10) % 10;
int birler = sayi % 10;
int toplam = yuzler + onlar + birler;

Console.WriteLine($"Yüzler basamaği: {yuzler}");
Console.WriteLine($"Onlar basamaği: {onlar}");
Console.WriteLine($"Birler basamaği: {birler}");
Console.WriteLine($"\nBasamaklarin Toplami: {yuzler} + {onlar} + {birler} = {toplam}");
int intAverage = (int)average;
        if (intAverage % 2 == 0)
        {
            Console.WriteLine("Average is even");
        }
        if (intAverage % 2 != 0)
        {
            Console.WriteLine("Average is odd");
        }

Console.WriteLine("enter student name:");
string name = Console.ReadLine();
Console.WriteLine("enter midterm score:");
int midterm = Console.ReadLine();
Console.WriteLine("enter  final score:");
int  final = Console.ReadLine();

double average = midterm * 0.4 + final * 0.6;
Console.WriteLine($"/n{name},your average is {average:F2}");


if(average >= 50)
  Console.WriteLine("result: passed");
else
  Console.WriteLine("result:failed");
if (final==100)
  Console.WriteLine("perfect final");

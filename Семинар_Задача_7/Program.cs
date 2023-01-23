// Написать программу, кот выводит случайное число из отрезка от 10 до 99 и показывает
//наибольшую цифру числа

int a = new Random().Next(10, 100);
Console.WriteLine(a);
int b = a / 10;
Console.WriteLine(b);
int c = a % 10;
Console.WriteLine(c);
if (b > c)
{
  Console.WriteLine($"больше {b}");  
}
else
Console.WriteLine($"больше {c}");  
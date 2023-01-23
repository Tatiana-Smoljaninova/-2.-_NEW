// Напишите прогр, кот выводит случайное трехзначное число и удаляет вторую цифру
//этого числа

int a = new Random().Next(100, 1000);
Console.WriteLine($"Выводим число а {a}");
int b = a/100;
Console.WriteLine($"Выводим число b {b}");
int c = a % 10;
Console.WriteLine($"Выводим число c {c}");
int d = b * 10 + c;
Console.WriteLine($"Выводим число d {d}");
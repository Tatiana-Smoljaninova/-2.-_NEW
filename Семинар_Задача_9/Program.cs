// Напишите прогр, кот будет принимать на вход два числа и выводить, является ли второе
//число кратным первому. Если число 2 не кратно числу 1, то прогр выводит остаток от
//деления. 
//Пр. 34 и 5 не кратно, остаток 4.
//    16 и 4 кратно

Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
if (b % a == 0)
{
    Console.Write("b кратно а");
}

else
{
    Console.Write("b не кратно a, остаток от деления ");
    Console.Write(b % a);
}
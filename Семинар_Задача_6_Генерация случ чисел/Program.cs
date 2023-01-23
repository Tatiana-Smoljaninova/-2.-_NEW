int a;
int x = 100;
int y = -100;
for (int i = 0; i < 10; i++)
{
    a = new Random().Next(y,x);
    Console.WriteLine(Math.Abs(a));//Math - в math хранятся математические функции
                                  //Abs - полученное значение берется /по модулю/
}

// double - дробные числа
// Math.Round(a) - округление до целого
// Math.Round(a, 2) - округление до 2-х знаков после запятой
//Math.Abs(a) - выводится модуль числа
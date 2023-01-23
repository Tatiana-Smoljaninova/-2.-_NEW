//"CONTINUE"
int a = 5;

for (int i = 0; i < length; i++)
{
    
}

while(a<10)
{
    a++;
    if (a == 8 || a == 7)
    {
        continue; //как только команда дошла до этой команды, она не прекращает цикл,
                  //но мы перемещаемся в начало цикла и не идем дальше по циклу      
        Console.WriteLine("1111"); //это не будет написано, т.к. выше "continue"
    }
    Console.WriteLine(a);
}
Console.WriteLine("ОК");
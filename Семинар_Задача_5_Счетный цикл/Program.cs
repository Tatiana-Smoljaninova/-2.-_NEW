﻿//Счетный цикл - переменная задается внутри цикла и все действия описываются
//в строке цикла
//в цикле while переменная д.б. создана до начала цикла. Тут переменная м.б. создана
//в самом цикле
int a = 5;

for (int i = 0; i < 10; i++) //i - переменная цикла. Она объявлена внутри цикла
                                //и доступна только в пределах цикла. За циклом она
                                //не будет доступна.
                                //i < length - условие, кот д.б. выполнено
                                //последующее действие, кот д.б. выполнено
{
    if (i == 8 || i == 7)
    {
        continue;     
        Console.WriteLine("1111"); //это не будет написано, т.к. выше "continue"
    }
    Console.WriteLine(i);
}
Console.WriteLine("ОК");

// Задача: Найти значение параметра, соответсвующего заданному индкесу

///void - метод, кот ничего не возвращает. 
// пишем первый метод (функцию) void - МЕТОД ЗАПОЛНЕНИЯ МАССИВА:
// FillArray - наименование метода (функции),
// collection - аргумент функции - это название аргумента (это параметр)

void FillArray(int[] collection) 
{
    //length - длинна массива
    //length - локальная переменная, collection - параметр,
    //команда Length - длина массива (int array lenght (get))
    //вводим тип и значения локальных переменных lenght & index
    int length = collection.Length; // получаем длину массива (int array lenght GET)
    int index = 0; // вводим начальноне значение индекса
    //изначально значения в массиве равны нулям. наполняем массив значениями
    //пока index значения массива меньше длинны
    while (index < length)
    {
        //обратимся к аргументу collection на позицию index (к массиву collection)
        //и положим туда случайное целое число от 1 до 10
        collection[index] = new Random().Next(1,10);
        //увеличим значение index на 1
        index++;
    }
}

//пишем второй метод void, который будет печатать массив - МЕТОД ПЕЧАТИ МАССИВА
void PrintArray(int[] col) //col - название аргумента (параметр)
{
    int count = col.Length; //обозначим количество элементов как длину массива col
    int position = 0; //обозначим текущую позицию через локальную переменную position
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

// IndexOf - название метода
//будет приходить аргумент collection и find
int IndexOf(int[] collection, int find) 
{
    int count = collection.Length; //определяем кол-во элементов count длинной collection
    int index = 0;
    //ввели "-1" чтобы если заданного числа нет в массиве, то возвращалось -1
    //и это говорит, что такого числа в массиве нет
    int position = -1; //БЫЛО: int position = 0;

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break; //оператор, кот останавливает дальнейшую работу выборки
        }
        index++;
    }
    return position;
}

// ! 1) определим массив из 10 элементов
//вводим тип (int[]) и значение (new int[10]) локальной переменной array
//new int[10] = создай новый массив, в котором будет 10 элементов
// По умолчанию он будет наполнен нулями. мы заполним его случайными числами
int[] array = new int[10]; // 
                        
// ! 2) вызвали метод FillArray, который заполнил этот массив
FillArray(array);
array[4] = 4; //пусть на 4 позиции будет цифра "4"
array[5] = 4; //пусть на 5 позиции будет цифра "4"
// ! 3) вызвали метод PrintArray, который распечалад массив
PrintArray(array); // вызываем метод PtintArray, кот распечатает массив
Console.WriteLine();

int pos = IndexOf(array, 444); // найти на какой позиции находится "4"
Console.WriteLine(pos);

// возвращает индекс заданного числа 4 в массиве
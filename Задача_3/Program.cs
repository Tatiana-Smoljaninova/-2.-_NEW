int[] array = {1, 2, 8, 4, 5, 6, 7, 8 }; // array - наименование массива

int n = array.Length; // длинна массива
int find = 8; // число, индекс которого нужно найти в массиве чисел

int index = 0;

while (index < n) // индекс меньше длинны массива
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; // прерви: т.е. если будет второе такое число - оно уже не будей найдено
    }   
    index++; //index = index + 1;
}
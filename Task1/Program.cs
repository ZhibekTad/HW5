// Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных 
// чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArray(int Length)
{
    int[] array = new int [Length];
    for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(100, 1000);
        }
        return array;
}

int CountEvenNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
        count = count + 1;
    return count;
}
int[] array = CreateArray(4);
Console.WriteLine($"Our array is {String.Join(" ", array)} and even number = {CountEvenNum(array)}");

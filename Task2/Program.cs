// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray(int Length)
{
    int[] array = new int[6];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}


int OddIndexNumSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (i % 2 == 1)
        sum += array[i];
    return sum;
}

int[] array = GetArray(6);
Console.WriteLine($"Our array is {String.Join(" ", array)} and odd index number sum = {OddIndexNumSum(array)}");
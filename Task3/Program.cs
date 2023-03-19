// Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] CreateArray(int Length)
{
    int[] array = new int [Length];
    for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(0, 30);
        }
        return array;
}

int[] array = CreateArray(5);
int min = array[0], max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (min > array[i])
        min = array[i];
    if (max < array[i])
    max = array[i];
}
//int diff = new int();
//diff = maxNum() - minNum();

Console.WriteLine($"Our array is {String.Join(" ", array)}");
Console.WriteLine($"Difference of max and min is {String.Join(" ", max - min)}");
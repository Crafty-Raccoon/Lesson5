//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2 

void FillArray(int[] arr)
{
    int length = arr.Length;
    int index = 0;
    while (index < length)
    {
        arr[index] = new Random().Next(100, 999);
        index++;
    }
}

void PrintArray(int[] arr)
{
    int length = arr.Length;
    int index = 0;
    Console.Write('[');
    while (index < length)
    {
        Console.Write($" {arr[index]}, ");
        index++;
    }
    Console.Write(']');
}

int evenNumCount(int[] arr)
{
    int length = arr.Length;
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (arr[i]%2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Введите размер массива");
int length = int.Parse(Console.ReadLine());

int[] array = new int[length];
FillArray(array);
PrintArray(array);
Console.Write($" -> {evenNumCount(array)} чётных элементов в массиве");
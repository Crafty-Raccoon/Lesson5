//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6]-> 0

void FillArray(int[] arr)
{
    int length = arr.Length;
    int index = 0;
    while (index < length)
    {
        arr[index] = new Random().Next(0, 10);
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

int oddIndexSum(int[] arr)
{
    int length = arr.Length;
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + arr[i];
        }
    }
    return sum;
}

Console.WriteLine("Введите размер массива");
int length = int.Parse(Console.ReadLine());

int[] array = new int[length];

FillArray(array);
PrintArray(array);

Console.WriteLine($" Сумма элементов на нечётных позициях = {oddIndexSum(array)}");
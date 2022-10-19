//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

double GenerateDouble(double min, double max)
{
    Random rnd = new Random();
    double number = rnd.NextDouble();
    double rndDouble = number * (max - min) + min;
    return rndDouble;
}

void FillDoubleArray(double[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = GenerateDouble(-10, 10);
    }
}// Диапазон (-10,10)

void PrintArray(double[] arr)
{
    int length = arr.Length;
    int index = 0;
    Console.Write('[');
    while (index < length)
    {
        Console.Write($" {Math.Round(arr[index], 2)} ");
        index++;
    }
    Console.Write(']');
}

double Sum(double[] arr)
{
    double min = arr.Min();
    double max = arr.Max();
    double sum = min - max;
    return sum;
}

Console.WriteLine("Введите размер массива");
int length = int.Parse(Console.ReadLine());

double[] array = new double[length];

FillDoubleArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементом = {Math.Round(Sum(array), 2)}");
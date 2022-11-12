﻿// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

double[] CreateRandomArray(int size, int start, int end)
{
    double[] RandomArray = new double[size];
    for (int i = 0; i < size; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


Console.WriteLine("Please enter array size:");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter the beginning and the end of interval from which array elements will be created:");
int start = Convert.ToInt32(Console.ReadLine());
int end = Convert.ToInt32(Console.ReadLine());
double[] array = CreateRandomArray(size, start, end);
ShowArray(array);

double diff = 0;
double min = array[0];
double max = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }
    else if (array[i] > max)
    {
        max = array[i];
    }
    diff = max - min;

}
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"The differnece between maximum ({max}) and minimum ({min}) array element is {diff}.");


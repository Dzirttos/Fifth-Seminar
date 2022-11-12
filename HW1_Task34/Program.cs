// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

int [] CreateRandomArray (int size, int start, int end)
{
    int [] RandomArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        RandomArray[i] = new Random().Next(start, end +1);
    }
    return RandomArray;
}

int [] CreateMyArray ()
{
    Console.WriteLine("Please enter array size:");
    int size = Convert.ToInt32(Console.ReadLine());
    int [] MyArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Please enter array element № {i+1}:");
        MyArray [i] = Convert.ToInt32(Console.ReadLine());
    }
    return MyArray;
}

void ShowArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

// int [] array = CreateRandomArray(9, -10, 10);
// ShowArray(array);

int [] array = CreateMyArray();
ShowArray(array);



    
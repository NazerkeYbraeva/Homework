// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите 
// программу, которая покажет количество чётных чисел
// в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++) 
    {
        array[i] = new Random().Next(99 + 1, 999);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

void CountEven(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count = count + 1;
        }
    }
    Console.WriteLine($"Количество четных элементов -> {count}");
}

Console.WriteLine("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());


int[] myArray = CreateRandomArray(size);
PrintArray(myArray);
CountEven(myArray);
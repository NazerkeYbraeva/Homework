// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным 
// элементов массива. double
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] DoubleRandomArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++) 
    {
        Random random = new Random();
        array[i] = Math.Round(random.NextDouble() * 100.0, 2);
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

void FindMinMaxDiff(double[] array)
{
    double max = array.Max();
    double min = array.Min();
    {
        Console.WriteLine($"Разница между максимальным и минимальным элементом -> {Math.Round(max - min, 2)}");
    }
    
}

Console.WriteLine("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());


double[] myArray = DoubleRandomArray(size);
PrintArray(myArray);
FindMinMaxDiff(myArray);
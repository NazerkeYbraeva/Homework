// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] Array(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++) 
    {
        Console.Write($"Input num {i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
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

void CountNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i] > 0)
        count = count + 1;
    }
        Console.WriteLine($"-> {count}");
}


Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = Array(size);
PrintArray(myArray);   
CountNum(myArray);  

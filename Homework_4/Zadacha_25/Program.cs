// Задача 25: Напишите цикл, который принимает на вход два числа
// (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int NaturalDegree(int a, int b)
{
    int naturalDegree = a;
    int count = 1;
     for (int i = a; count < b; count++) 
    {
        naturalDegree = naturalDegree * i;
    }
    return naturalDegree;
}
Console.WriteLine("Input a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NaturalDegree(a, b));
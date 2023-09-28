// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int FindSumDigit(int num)
{
    int sum = 0;
    for (int i = 0; num > 0;) 
    {
        i = num % 10;
        sum += i;
        num /= 10;
    }
    return sum;
}
Console.WriteLine("Input num: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindSumDigit(num));
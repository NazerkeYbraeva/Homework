﻿//Задача 8: Напишите программу, которая на вход принимает 
//число (N), а на выходе показывает все чётные числа от
//1 до N.

Console.WriteLine("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;
while(count <= n)
{
  if(count % 2 == 0)
{
    Console.WriteLine(count);
}
count++;
}
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.
using System.Net;

Console.WriteLine("Введи число m");
int start = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(n);
Console.WriteLine("Введи число n");
int end = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(NaturalNumber(start, end));

string NaturalNumber(int start, int end)
{
    if ( start == end)
        return start.ToString();
   return $"{start} {NaturalNumber(++start, end)}";
}


// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.
// using System.Net;

// Console.WriteLine("Введи число m");
// int start = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine(n);
// Console.WriteLine("Введи число n");
// int end = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(NaturalNumber(start, end));

// string NaturalNumber(int start, int end)
// {
//     if ( start == end)
//         return start.ToString();
//    return $"{start} {NaturalNumber(++start, end)}";
// }
//-----------------------------------------------------------------------
// Задача 3: Задайте произвольный массив. Выведете его элементы, 
// начиная с конца. Использовать рекурсию, не использовать циклы.
// class MainReturn 
// {
//     static void Main(string[] args)
//     {
//         int[] array = { 1, 3, 7, 4, 18, 20 };

//         PrintArrayReversed(array, array.Length - 1);
//     }

//     static void PrintArrayReversed(int[] arr, int index)
//     {
//         if (index >= 0)
//         {
//             Console.Write(arr[index] + " ");
//             PrintArrayReversed(arr, index - 1);
//         }

//     }
// }
//----------------------------------------------------------
//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// AkkermanFunction(m, n);

// void AkkermanFunction(int m, int n)
// {
//     Console.Write(Akkerman(m, n));
// }

// int Akkerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0 && m > 0)
//     {
//         return Akkerman(m - 1, 1);
//     }
//     else
//     {
//         return (Akkerman(m - 1, Akkerman(m, n - 1)));
//     }
// }
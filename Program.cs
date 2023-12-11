// 1) Задание ввести два числа, нужно найти какое больше и меньше и вывести на экран
// Console.Write("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// {
// if (firstNumber == secondNumber)
//   { 
// Console.WriteLine ($"Введенные числа равны `{secondNumber}`");
// }
// if (firstNumber < secondNumber)
//   { 
// Console.WriteLine ($"Первое число `{firstNumber}` меньше чем второе `{secondNumber}`");
// 
// else 
//    Console.WriteLine ($"Первое число `{firstNumber}` больше чем второе `{secondNumber}`");
//    }
// }
// -------------------------------------
//  Задача 2 Программа принимает 3 числа и выдает максимальное
// Console.Write("Введите первое число: ");
//int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
//int b = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите второе число: ");
//int c = Convert.ToInt32(Console.ReadLine());
//int max = a;
//int max1 = 1;
//{
//  if (b > c)
// max1 = b;
// else 
// max1 = c;
// if (max > max1)
// Console.WriteLine("Максимальное число" + max);
// else
//  Console.WriteLine("Максимальное число" + max1);
// }
//----------------------------------------------
// Задача 3 принимает число и выводи, является ли он четным или нет
//Console.Write("Введите число: ");
//int number = Convert.ToInt32(Console.ReadLine());
//{
//  if (number / 2 == 0)
// Console.WriteLine($"Число  `{number}` четное");
// else
// Console.WriteLine($"Число `{number}` нечетное");
//}
// --------------------------------------------------
// Задача 4
// на вход принимает число, а на выходе выводит все четные числа от 1 до number включительно, разделенные табуляцией
//Console.Write("Введите число: ");
//int number = Convert.ToInt32(Console.ReadLine());
//for (int count = 2; count <= number; count +=2)
//Console.Write($"{count}\t");
// -----------------------------------------------
// Задача:  Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.
// int a = new Random().Next(150,1000);
// Console.WriteLine(a);
// if ( a % 168 == 0 )
//  Console.WriteLine("YES");
// else
//  Console.WriteLine("no");
//---------------------------------------------------
// Задача: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и 
// показывает наибольшую цифру числа.
////Console.Clear();
//int a = new Random().Next(10,99);
//Console.WriteLine(a);
//int n1 = a / 10;
//int n2 = a % 10;
//if (n1 > n2)
 //   Console.WriteLine(n1);
//else
//    Console.WriteLine(n2);
// ---------------------------------------------------
// Задача Напишите программу, которая на вход принимает натуральное число N,
// а на выходе показывает его цифры через запятую.
//Console.Write("Введите число N: ");
//int N = Convert.ToInt32(Console.ReadLine());
//
//if (N < 10)
//Console.Write(N);

//else
//{
//    while (N > 0)
//    {
//       int carrentDid = N % 10;
//       N/=10;
//       if (N > 0)
//    {
//        Console.Write(carrentDid + ",");
//    }
//       else
//       {
//         Console.Write(carrentDid);
//       }}}


Задайте массив из N случайных целых чисел (N вводится с
клавиатуры).
Найдите количество чисел, которые оканчиваются на 1 и
делятся нацело на 7.
Пример
[1 5 11 21 81 4 0 91 2 3]
=> 2

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 20);
}

// функция возвращает True если число простое, иначе False
bool CheckProst(int x)
{
    for (int j = 2; j < x; j++)
        if (x % j == 0)
            return false;
    return true;
}


void ReleaseArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (CheckProst(array[i]) == true)
            count ++;
    Console.WriteLine(count);
}

Console.Clear();
Console.Write("Введите число элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine(string.Join(", ", array));
ReleaseArray(array);

































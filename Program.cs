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
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
for (int count = 2; count <= number; count +=2)
Console.Write($"{count}\t");


























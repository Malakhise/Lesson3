// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100.
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].
// Console.Clear();
// Console.Write("Введите кол-во элементов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// for(int i = 0; i < array.Length; i++)
//    array[i] = new Random().Next(1, 100); //[1;100]
// Console.WriteLine(string.Join(", ", array));
// int count = 0;
// for(int i = 0; i < array.Length; i++)
//    {
//       if (array[i] > 19 && array[i] < 90)
//       count++;
//    } 
// Console.WriteLine(count);
//-----------------------------------------------------------
// Задайте массив на 10 целых чисел. Напишите программу, 
// которая определяет количество чётных чисел в массиве.
// Console.Clear();
// Console.Write("Введите кол-во элементов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// for(int i = 0; i < array.Length; i++)
//    array[i] = new Random().Next(); //[без ограничений]
// Console.WriteLine(string.Join(", ", array));
// int count = 0;
// for(int i = 0; i < array.Length; i++)
//    {
//       if (array[i] % 2 == 0)
//       count++;
//    } 
//Console.WriteLine(count);
//-------------------------------------------------------------
// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.
//double[] array = {3.14, 2.78, 4.54, 70.35};
//               double N = 10;
//               double[] array = new double[N]; выдает ошибку, почему?
//double max = array[0];
//double min = array[0];
//double differece = 0;
//for(int i = 0; i < array.Length; i++)
//{
//      if (array[i] > max)
//      max = array[i];
//   }
//   for (int j = 0; j < array.Length; j++)
//   {
//    if (array[j] < min)
//     min = array[j];
//   }
//differece = max - min;
//  Console.WriteLine(max);
//Console.WriteLine(min);
//Console.WriteLine(differece);
//---------------------------------------------------------
// 
//            Задачи из семинара 2 Функции УРОК 4
//Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//  void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(100, 1000);
// }

// // функция возвращает True если число простое, иначе False
// bool CheckProst(int x)
// {
//         if (x % 2 == 0)
//             return true;
//     return false;
// }


// void ReleaseArray(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//         if (CheckProst(array[i]))
//             count ++;
//     Console.WriteLine(count);
// }

// Console.Clear();
// Console.Write("Введите число элементов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine(string.Join(", ", array));
// ReleaseArray(array);
//--------------------------------------------------------------------
//Задача 3: Напишите программу, которая перевернёт одномерный массив 
//(первый элемент станет последним, второй – предпоследним и т.д.)
// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(1, 100);
// }
 
//  void ReplacementArray(int[] array)
// {
//      int temp;
//   for (int i = 0; i < array.Length / 2; i++) // цикл до середины массива
//  {
//     temp = array[i];
//     array[i] = array[array.Length - 1 - i]; // обращение через последний эл.т массива
//     array[array.Length - 1 - i] = temp;
// }
// }

// void ReleaseArray(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
//    Console.Write($"{array[i]}, ");
// }

// Console.Clear();
// Console.Write("Введите число элементов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine(string.Join(", ", array));
// ReplacementArray(array);
// ReleaseArray(array);



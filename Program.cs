// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100.
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].
Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for(int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 100); //[1;100]
Console.WriteLine(string.Join(", ", array));
int count = 0;
for(int i = 0; i < array.Length; i++)
    {
       if (array[i] > 19 && array[i] < 90)
       count++;
    } 
 Console.WriteLine(count);




























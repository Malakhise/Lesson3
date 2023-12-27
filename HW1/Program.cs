// string str = "Hello";
// char[] array = new char[str.Length];
// for (int i = 0; i < array.Length; i++)
//     array[i] = str[i];

// Console.WriteLine($"'{str}' => [{string.Join(", ", array)}]");

// string name = "Rustem";
// int age = 50;
// string city = "Krasnodar";
// Console.WriteLine("Меня зовут " + name + ", мне " + age + " лет. Я из города " + city + ".");
// Console.WriteLine($"Меня зовут {name}, мне {age} лет. Я из города {city}.");

// char[] glas = new char[3] { 'e', 'o', 'a'};

//             string str = " Hello world";
//             int count = 0;
//             for(int i=0;i<str.Length;i++)
//             {
//                 for (int j = 0; j < glas.Length; j++)
//                 {
//                     if (glas[j] == str[i]) 
//                     count++;
//                 }
//             }
//             Console.WriteLine(count);
// Задание 2 
//Напишите программу, которая выводит все натуральные числа в промежутке от 1 до N
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine(IterrateAndPrint(1,N));

// string IterrateAndPrint(int start, int end)
// {
//     if(start == end)
//     return start.ToString();
//  return $"{start} {IterrateAndPrint(++start,end)}";
// }
//-----------------------------------------------------------------
// // Введите два числа, и возведите первое в степень второго, при помощи рекурсии.
// using System.Reflection.Metadata.Ecma335;

// System.Console.WriteLine("введите число А; ");
// int number = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("введите число B; ");
// int rank = Convert.ToInt32(Console.ReadLine());

// int Pow( int number, int rank)
// {
//     if (rank == 0)
//     return 1;
//     if (rank ==1)
//     return number;

//     return number * Pow(number,--rank);
// }
// System.Console.WriteLine(Pow(number, rank));
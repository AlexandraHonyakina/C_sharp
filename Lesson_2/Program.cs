// int[] arr = new int[5];
// arr[0] = 5;
// arr[1] = 7;
// arr[2] = 9;
// arr[3] = 11;
// arr[4] = 1;
// Console.WriteLine(arr[0]);
// Console.WriteLine(arr[1]);
// Console.WriteLine(arr[2]);
// Console.WriteLine(arr[3]);
// Console.WriteLine(arr[4]);
// //Console.WriteLine(arr[5]);  

// int[] arr2 = new int[5] {1, 2, 3, 4, 5};

// int[] arr3 =  {10, 20, 30, 40, 50};

// Задача 1. Создать массив. и вывести массив.

// int n = 10;
// int[] arr = new int[n];
// int i = 0;

// while (i<n)
// {
// arr[i] = i + 1;
// // Console.Write(arr[i]);
// // Console.Write(' ');
// Console.Write($"{arr[i]} ");
// i = i + 1;

// }

//  Задача 2Создать целочисленный массив на 10 элементов
//  и заполнить его произвольными числами. 
//  Вывести на экран четные элементы

// int n = 10;
// int[] arr = {12, 5, 36, 9, 17, 11, 3, 52, 9, 13};
// int i = 0;

// while (i<n)
// {
//     if(arr[i] % 2 == 0)
//     {
//     Console.Write($"{arr[i]} ");
//     }
// i = i + 1;
// }


//Задача 3 . Найти макс из 5 гирь.
int n = 5;
int[] arr = {12, 5, 36, 9, 17};
int i = 0;
int max = 0;

while (i<n)
{
    if(arr[i] > max)
    {
    max = arr[i];
    }
i = i + 1;
}
Console.Write($"{max} ");


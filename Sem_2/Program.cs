// // Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

//  if (number % 7 == 0 && number % 23 == 0)
// {
//     Console.WriteLine($"Число {number} кратно и 7, и 23 одновременно");
// }
// else
// {
//     Console.WriteLine($"Число {number} не кратно 23 и 7  одновременно");
// }



// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

// Console.Write("Введите x точки: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y точки: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0)
// {
//     Console.WriteLine($"Точка с координатами {x}, {y} находится в I четверти координатной плоскости");
// }
// else
// {
//     if (x < 0 && y > 0)
// {
//     Console.WriteLine($"Точка с координатами {x}, {y} находится во II четверти координатной плоскости");
// }
// else
// {
//     if (x < 0 && y < 0)
// {
//     Console.WriteLine($"Точка с координатами {x}, {y} находится в III четверти координатной плоскости");
// }
// else
// { Console.WriteLine($"Точка с координатами {x}, {y} находится в IV четверти координатной плоскости");
// }
// }
// }



// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int copyNumber = number;
// int addVar = number % 10;
// int result = number / 10;

// if (number >= 10 && number <= 99)
// { 
//     if (addVar > result)
//     {
//         result = addVar;
//     }

// Console.WriteLine($"Наибольшая цифра от: {copyNumber} = {result} ");
// }
// else
// {
//     Console.WriteLine($"Число {copyNumber} не принадлежит отрезку [10, 99]");
// }


// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.


// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

//  while (number % 10 != 0)
//  {
//        Console.Write(number % 10 + ", ");
//        number = number / 10;
// }



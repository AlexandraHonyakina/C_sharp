Console.WriteLine("Введите первое число:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
      
Console.WriteLine("Введите второе число:");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.WriteLine(firstNumber + " больше, чем " + secondNumber);
}
else
{
   if (firstNumber < secondNumber)
{
    Console.WriteLine(secondNumber + " больше, чем " + firstNumber);
}
else
{
    Console.WriteLine("Оба числа равны");

    }
    }


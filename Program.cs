// Функционал Console.WritLine()
/*
int number1 = 5;
int number2 = 8;


Console.WriteLine("My numbers are " + number1 + " and " + number2 + " and its good!");

Console.WriteLine($"My numbers are {number1} and {number2} and its good!");

// --------------------------------------------
*/


// Функционал Console.ReadLine()
/*
Console.Write("Input an integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Your number is " + num);

// --------------------------------------------
*/

// Задача 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
/*
Console.Write("Input a first number:  ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number:  ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad2 = num2 * num2;

if(num1 == quad2)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
//------------------------------------------
*/

// Задача 2. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
/*
Console.Write("Input a number:  ");
int n = Convert.ToInt32(Console.ReadLine());

int current = -n;

while(current <= n)
{
    Console.Write(current + " ");
    current += 1;
}
*/

5 / 2 = 2 
5 % 2 = 1

34862 / 10 = 3486
34862 / 100 = 348
34862 / 1000 = 34
34862 / 10000 = 3


34862 % 10 = 2
34862 % 100 = 62
34862 % 1000 = 862
34862 % 10000 = 4862

45346 -> 53
45346 / 100 = 453
453 % 100 = 53

/*
//--------------------------------------------------




















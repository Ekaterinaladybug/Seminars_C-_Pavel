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
/*
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

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
/*
Console.Write("Input integer first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integer second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine($"First number {num1} is greater than second number {num2}");
    Console.WriteLine($"Second number {num2} is less than first number {num1}");
}
else
{
    Console.WriteLine($"Second number {num2} is greate than first number {num1}");
    Console.WriteLine($"First number {num1} is less second number {num2}");
}    

*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
/*
Console.Write("Input integer first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integer second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integer third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(max < num2)
{
    if(num2 > num3)
    {
        max = num2;
        Console.Write($"Max number {max}");
    }
    else
    {
        max = num3;
        Console.Write($"Max number {max}");
    }
     
}
else
{
    if(max < num3)
    {
        max = num3;
        Console.Write($"Max number {max}");
    }
    else
        max = num1;
        Console.Write($"Max number {max}");
}
*/
// ----------------------------------------------

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
4 -> да
-3 -> нет
7 -> нет
*/
/*
Console.Write("Input integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = 2;


if(num1 % num2 == 0)
{
    Console.Write($"Number {num1} is even");
}
else
{
    Console.Write($"Number {num1} is odd");
}
*/
// ------------------------------------------------------

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
/*
Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine ());
int num2 = 2;
int current = 1;

while(current <= n)
{
    if(current % num2 == 0)
    {
        Console.Write(current + " ");
        current += 1;
    }
    else
    {
        current += 1;
    } 
}
*/
// ------------------------------------------
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел. Другое решение.
/*
Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = 0;

if(max<num1) max = num1;
if(max<num2) max = num2;
if(max<num3) max = num3;

Console.WriteLine($"Max number {max}");
*/
// ----------------------------------------------

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел. Другое решение 2.

Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(max<num2) max = num2;
if(max<num3) max = num3;

Console.WriteLine($"Max number {max}");
















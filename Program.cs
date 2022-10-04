/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.WriteLine("____________________");
Console.WriteLine("Задача 1");
Console.WriteLine();
Console.WriteLine("Введите первое число");
int Num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int Num2 = int.Parse(Console.ReadLine()!);

Console.WriteLine();
Console.Write("Ответ: ");
if (Num1 < Num2)
{

    Console.WriteLine($"a = {Num1}; b = {Num2} -> max = {Num2}");
}
else if (Num1 > Num2)
{
    Console.WriteLine($"a = {Num1}; b = {Num2} -> max = {Num1}");
}
else
{
    Console.WriteLine("Числа равны. Нет максимального числа");
}

/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/* 2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.WriteLine("____________________");
Console.WriteLine("Задача 2");
Console.WriteLine();
Console.WriteLine("Введите первое число");
int Num01 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int Num02 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число");
int Num03 = int.Parse(Console.ReadLine()!);
int max = Num01;

Console.WriteLine();
Console.Write("Ответ: ");
if (max < Num02)
{
    Console.WriteLine($"{Num01}, {Num02}, {Num03} -> {Num02}");
}
else if (Num02 < Num03)
{
    Console.WriteLine($"{Num01}, {Num02}, {Num03} -> {Num03}");
}
else
{
    Console.WriteLine($"{Num01}, {Num02}, {Num03} -> {max}");
}

/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */

Console.WriteLine("____________________");
Console.WriteLine("Задача 3");
Console.WriteLine();
Console.WriteLine("Введите число: ");
int Num = int.Parse(Console.ReadLine()!);

if (Num%2==0)
{
    Console.WriteLine();
    Console.WriteLine($"{Num} -> да");
}
else
{
    Console.WriteLine();
    Console.WriteLine($"{Num} -> нет");
}

/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

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
    Console.WriteLine($"NUM0001 = {Num1}; b = {Num2} -> max = {Num2}");
}
else if (Num1 > Num2) // вложенный if 
{
    Console.WriteLine($"NUM0001 = {Num1}; b = {Num2} -> max = {Num1}");
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
    max = Num02; // присвоение "max" новому числу
}
if (max < Num03)
{
    max = Num03;
}
Console.WriteLine($"{Num01}, {Num02}, {Num03} -> {max}");

/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */

Console.WriteLine("____________________");
Console.WriteLine("Задача 3");
Console.WriteLine();
Console.WriteLine("Введите число: ");
int Num001 = int.Parse(Console.ReadLine()!);

Console.WriteLine();
Console.Write("Ответ: ");
if (Num001%2==0) // % деление без остатка
{
    Console.WriteLine($"{Num001} -> да");
}
else
{
    Console.WriteLine($"{Num001} -> нет");
}

/* Задача 8: Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.WriteLine("____________________");
Console.WriteLine("Задача 4");
Console.WriteLine();
Console.WriteLine("Введите число: ");
int NUM0001 = int.Parse(Console.ReadLine()!);
int a = 1;

Console.WriteLine();
Console.Write("Ответ: ");
while (a <= NUM0001) // Оператор while позволяет повторять выполнение оператора до тех пор, пока указанное выражение не станет ложным.
{
    if (a%2==0) 
    {
        Console.Write($"{a}, ");

    }
    a++;
}
Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop); // удаление лишней запятой в конце (удаление 2 символов в конце)
Console.WriteLine("  "); // удаление лишней запятой в конце (вставить пустую строчку с пробелами. без этого прошлая операция не работает)
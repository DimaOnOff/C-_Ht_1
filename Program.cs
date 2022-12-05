// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

//Console.WriteLine("Enter Number 1 ");
//int num1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter Number 2 ");
//int num2 = int.Parse(Console.ReadLine());

//if (num1 > num2)
//{
//    Console.WriteLine($"max = {num1}");
//    Console.WriteLine($"min = {num2}");
//}
//else if (num1 < num2)
//{
//    Console.WriteLine($"max = {num2}");
//    Console.WriteLine($"min = {num1}");
//}
//else 
//{
//    Console.WriteLine("equel");
//}

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

//Console.WriteLine("Enter Number 1 ");
//int num1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter Number 2 ");
//int num2 = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter Number 3 ");
//int num3 = int.Parse(Console.ReadLine());

//if ((num1 >= num2) && (num1 >= num3))
//{
//    Console.WriteLine($"max = {num1}");
//}
//else if ((num1 <= num2) & (num2 >= num3))
//{
//    Console.WriteLine($"max = {num2}");
//}
//else 
//{
//    Console.WriteLine($"max = {num3}");
//}

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

//Console.WriteLine("Enter number ");
//int num = int.Parse(Console.ReadLine());
//if (num % 2 == 0)
//{
//    Console.WriteLine("even integer");
//}
//else
//{
//    Console.WriteLine("odd integer");
//}

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Enter number ");
int n = int.Parse(Console.ReadLine());
int i = 1;
while (i <= n)
{
    if (i % 2 == 0)
    {
    Console.WriteLine($"even integer {i}");
    }
    i++;
}


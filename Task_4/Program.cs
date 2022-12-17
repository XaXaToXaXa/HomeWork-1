// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.

// Console.WriteLine("Введите первое целое число");
// string stringNumberA = Console.ReadLine().Trim();
// int numberA;
// while(!int.TryParse(stringNumberA, out numberA))
// {
//     Console.WriteLine("Ошибка! Введите одно целое число!");
//     stringNumberA = Console.ReadLine().Trim();
// }
// Console.WriteLine("Введите второе целое число");
// string stringNumberB = Console.ReadLine().Trim();
// int numberB;
// while(!int.TryParse(stringNumberB, out numberB))
// {
//     Console.WriteLine("Ошибка! Введите одно целое число!");
//     stringNumberB = Console.ReadLine().Trim();
// }
// Console.WriteLine("Введите третье целое число");
// string stringNumberС = Console.ReadLine().Trim();
// int numberС;
// while(!int.TryParse(stringNumberС, out numberС))
// {
//     Console.WriteLine("Ошибка! Введите одно целое число!");
//     stringNumberС = Console.ReadLine().Trim();
//}
Console.WriteLine("Введите первое целое число ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье целое число ");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if (numberB > max)  max = numberB;
if (numberC > max)  max = numberC;
Console.WriteLine("Максимальное из введеных чисел " + max);
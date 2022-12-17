// Напишите программу, которая на вход принимает
// два числа и выдает, какое число большее, а какое меньшее.

//Простой вариант
// Console.WriteLine("Введите целое число ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите ещё одно целое число ");
// int numB = Convert.ToInt32(Console.ReadLine());
// if (numA > numB)
// {
//     Console.WriteLine($"Число  {numA} больше числа {numB}");
// }
// else
// {
//     Console.WriteLine($"Число  {numB} больше числа {numA}");
//  }

//Расширеный вариант
Console.WriteLine("Введите первое целое число");
string stringNumberA = Console.ReadLine().Trim();
int numberA;
while(!int.TryParse(stringNumberA, out numberA))
{
    Console.WriteLine("Ошибка! Введите одно целое число!");
    stringNumberA = Console.ReadLine().Trim();
}
Console.WriteLine("Введите второе целое число");
string stringNumberB = Console.ReadLine().Trim();
int numberB;
while(!int.TryParse(stringNumberB, out numberB))
{
    Console.WriteLine("Ошибка! Введите одно целое число!");
    stringNumberB = Console.ReadLine().Trim();
}
if (numberA > numberB)
{
    Console.WriteLine($"Число  {numberA} больше числа {numberB}");
}
else
{
    Console.WriteLine($"Число  {numberB} больше числа {numberA}");
}
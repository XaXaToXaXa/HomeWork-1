// Напишите программу, которая на вход принимает
// число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите целое число");
string stringNumberA = Console.ReadLine().Trim();
int numberA;
while(!int.TryParse(stringNumberA, out numberA))
{
    Console.WriteLine("Ошибка! Введите одно целое число!");
    stringNumberA = Console.ReadLine().Trim();
}
if (numberA > 0)
{
    int count = 0;
    Console.WriteLine ("Четные числа: ");
    while (count < numberA - 1)
    {
        count += 2;
       Console.WriteLine (count);
    }
}
else 
{
    int count = 0;
    Console.WriteLine ("Четные числа: ");
    while (count > numberA + 1)
    {
        count -= 2;
        Console.WriteLine (count);
    }
}
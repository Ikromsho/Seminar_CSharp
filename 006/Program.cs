// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
//  какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Уважаемый Габиль, введите первое число: ");
int GabilNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Уважаемый Габиль, введите второе число: ");
int GabilNum2 = Convert.ToInt32(Console.ReadLine());
if (GabilNum > GabilNum2) 
{
    Console.Write("Габиль, проведя сложные вычисления мы определили что max = ");
    Console.WriteLine(GabilNum);
} 
else
{
    Console.Write("Габиль, проведя сложные вычисления мы определили что max= ");
    Console.WriteLine(GabilNum2);
}
// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет,
//  является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет


Console.Write("Введите первое число: ");
string strNum1 = Console.ReadLine();
int num1 = int.Parse(strNum1);
Console.Write("Введите второе число: ");
string strNum2 = Console.ReadLine();
int num2 = int.Parse(strNum2);
if(num1 == num2 * num2) {
    Console.WriteLine("Певрое число является квадратом второго числа.");
} else {
    Console.WriteLine("Первое число не является квадратом второго числа.");
}
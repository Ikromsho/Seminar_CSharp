// Задача 8: Напишите программу, 
// которая на вход принимает число (N), а на выходе показывает все чётные числа 
// от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Мир Вашему дому!");
Console.Write("Уважаемый Габиль, введите число: ");
int GabilNum = Convert.ToInt32(Console.ReadLine());
int index = 1;
while(index <= GabilNum) {
    if (index % 2 == 0)
    Console.WriteLine(index);
    index++;
}

// Выполнен
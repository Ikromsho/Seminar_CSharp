// Задача 4: Напишите программу, 
// которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.Write("Уважаемый Габиль, введите первое число: ");
int GabilNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Уважаемый Габиль, введите второе число: ");
int GabilNum2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Уважаемый Габиль, введите третье число: ");
int GabilNum3 = Convert.ToInt32(Console.ReadLine());
int maxGabilNumber = GabilNum3; 
if (maxGabilNumber < GabilNum) {
    maxGabilNumber = GabilNum;
     Console.Write("Габиль, проведя сложные вычисления мы определили что max = ");
     Console.WriteLine(maxGabilNumber);
} 
else if (maxGabilNumber < GabilNum2) {
    maxGabilNumber = GabilNum2;
     Console.Write("Габиль, проведя сложные вычисления мы определили что max = ");
     Console.WriteLine(maxGabilNumber);
}
else {
    maxGabilNumber = GabilNum3;
     Console.Write("Габиль, проведя сложные вычисления мы определили что max = ");
     Console.WriteLine(maxGabilNumber);
} 

//Выполнен
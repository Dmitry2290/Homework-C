// Напишите программу, которая на вход принимает два числа и выдаёт
// , какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое числло: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;

if(numA > numB)
{
    max = numA;
    min = numB;
    }
else
{
    max = numB;
    min = numA;
    }

Console.WriteLine("max = " + max + " и " + "min = " + min);

// Напишите программу, которая принимает на вход три 
// числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
int NumA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе чило: ");
int NumB = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввидите третье число: ");
int NumC = Convert.ToInt32(Console.ReadLine());
int max = 0;

if(NumA > max)
{
    max = NumA;
}
if(NumB > max)
{
    max = NumB;
}
if(NumC > max)
{
    max = NumC;
}

Console.WriteLine("max = " + max);

// Напишите программу, которая на вход принимает число и
//  выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите первое число: ");
int NumA = Convert.ToInt32(Console.ReadLine());
int remDiv = NumA % 2;
if(remDiv == 0){

    Console.WriteLine("Да");
}
else{
    Console.WriteLine("Нет");
}

// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int evenNumber = 2;

if(number > 1){

    while(evenNumber <= number){

        Console.Write(evenNumber + " ");
        evenNumber = evenNumber + 2;
    }
}
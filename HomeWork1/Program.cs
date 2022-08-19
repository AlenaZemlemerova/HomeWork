// Задача 2: Напишите программу, которая на вход принимает два числа 
//и выдаёт, какое число большее, а какое меньшее

void Exercice2(int firstNumber, int secondNumber)
{
if (firstNumber > secondNumber)
{
    Console.WriteLine($"Первое число большее и равно {firstNumber}");
    Console.WriteLine($"Второе число меньшее и равно {secondNumber}");
}
else if (secondNumber > firstNumber)
{
    Console.WriteLine($"Первое число меньшее и равно {firstNumber}");
    Console.WriteLine($"Второе число большее и равно {secondNumber}");
} else
{
    Console.WriteLine("Числа равны");
}
}
Console.WriteLine("Задача 2: ");
Exercice2(5, 7);
Console.WriteLine("____________");
Exercice2(2, 10);
Console.WriteLine("____________");
Exercice2(-9, -3);
Console.WriteLine("");



// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int Exercice4(int a, int b, int c)
{
int max = a;
if (max < b)
{
    max = b;
}
if (max < c)
{
    max = c;
}
Console.WriteLine($"Максимальное число = {max}");
return max;
}
Console.WriteLine("Задача 4: ");
Exercice4(2, 3, 7);
Console.WriteLine("____________");
Exercice4(44, 5, 78);
Console.WriteLine("____________");
Exercice4(22, 3, 9);
Console.WriteLine("");


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

void Exercice6 (int number)
{
    if(number % 2 == 0)
    {
        Console.WriteLine("Число является чётным");
    }
    else
    {
        Console.WriteLine("Число является нечётным");
    }
}
Console.WriteLine("Задача 6: ");
Exercice6(4);
Console.WriteLine("____________");
Exercice6(-3);
Console.WriteLine("____________");
Exercice6(7);
Console.WriteLine("");


//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

void Exercice8 (int n)
{
    int currentNumber = 1;
    while (currentNumber <= n)
    {
        if (currentNumber % 2 == 0)
        {
            Console.Write(currentNumber + " ");
        }
        currentNumber++;
    }
    Console.WriteLine();
}
Console.WriteLine("Задача 8: ");
Exercice8 (5);
Console.WriteLine("____________");
Exercice8 (8);

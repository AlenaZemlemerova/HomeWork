// Задача 10: Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого числа.
int Exercice10 ()
{
    Console.WriteLine("Введите число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    if(a > 99 && a < 1000)
    {
        int secondDigit = (a / 10) % 10;
        System.Console.WriteLine(secondDigit);        
    } else
    {
        System.Console.WriteLine("Введено не трехзначное число");
    }
    return a;
}
Exercice10();


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int Exercice13 ()
{
    Console.WriteLine("Введите число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    if (a > 99)
    {
        for (int i = a; i > 99; i /= 10)
        {
            if (i < 1000)
            {
                Console.WriteLine(i % 10);
            }            
        }                       
    }
    else
    {
        System.Console.WriteLine("Третьей цифры нет");
    }
    return a;
}
Exercice13();


//Задача 15: Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.
void Exercice15 ()
{
    Console.WriteLine("Введите цифру, обозначающую день недели:");
    Console.WriteLine("1 - пн, 2 - вт, 3 - ср, 4 - чт, 5 - пт, 6 - сб, 7 - вс");
    int a = Convert.ToInt32(Console.ReadLine());
    if(a == 6 || a == 7)
    {
        Console.WriteLine("Сегодня выходной");
    }
    else if (a < 1 || a > 7)
    {
        Console.WriteLine("Введено некорректное число");
    }
    else
    {
        Console.WriteLine("Сегодня будний день");
    }
}
Exercice15();



// Задача 19. Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.

bool Exercice19()
{
    Console.WriteLine("Введите пятизначное число: ");
    string number = Console.ReadLine();
    if(number.Length == 5)
    {
        if(number[0] == number[4] && number[1] == number[3])
        {
            Console.WriteLine("Число является палиндромом");
        }
        else
        {
            Console.WriteLine("Число не является палиндромом");
        }
    }
    else
    {
        System.Console.WriteLine("Введено не пятизначное число");
    }
    return true;
}
Exercice19();

//Задача 21. Напишите программу, которая принимает на вход 
//координаты двух точек и находит расстояние между ними в 3D пространстве.

double Exercice21()
{
    Console.WriteLine("Введите координату по оси X первой точки: ");
    int ax = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату по оси Y первой точки: ");
    int ay = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату по оси Z первой точки: ");
    int az = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату по оси X второй точки: ");
    int bx = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату по оси Y второй точки: ");
    int by = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату по оси Z второй точки: ");
    int bz = Convert.ToInt32(Console.ReadLine());
    double distance = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
    Console.WriteLine(Math.Round(distance, 2));
    return distance;
}
Exercice21();

//Задача 23. Напишите программу, которая принимает на вход 
//число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Exercice23()
{
    Console.WriteLine("Введите число N: ");
    int number = Convert.ToInt32(Console.ReadLine());
    for(int i = 1; i <= number; i++)
    {
        double result = Math.Pow(i, 3);
        Console.Write(result + " ");
    }
}
Exercice23();

// // Задача 19
// // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// // 14212 -> нет
// // 12821 -> да
// // 23432 -> да

Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine()!;

// Решение припомощи булева метода
CheckingPolindrom(number);

bool CheckingPolindrom(string number)
{
    if (number.Length == 5)
    {
        if (number[0] == number[4] && number[1] == number[3])
        {
            System.Console.WriteLine($"{number} -> да");
        }
        else
        {
            System.Console.WriteLine($"{number} -> нет");
        } 
    }
    else
    {
        System.Console.Write("Число не является пятизначным");
        return false;
    }
    return true;
}


// void CheckNumber(string number) 
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         System.Console.WriteLine($"{number} -> да");
//     }
//     else
//     {
//         System.Console.WriteLine($"{number} -> нет");
//     }
// }

// if (number.Length == 5)
// {
//     CheckNumber(number);
// }
// else 
// {
//     System.Console.Write("Число не является пятизначным");
// }

// // Задача 21
// // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// // A (3,6,8); B (2,1,-7), -> 15.84
// // A (7,-5, 0); B (1,-1,9) -> 11.53
// int ReadData(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());

// }
// // вычисление координат в функции
// double Distance(int ax, int ay, int az, int bx, int by, int bz)
// {
//    return Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2));
// }

// int[] a = new int[3];
// int[] b = new int[3];

// a[0] = ReadData("Введите координату Х точки А");
// a[1] = ReadData("Введите координату Y точки А");
// a[2] = ReadData("Введите координату Z точки А");
// b[0] = ReadData("Введите координату Х точки B");
// b[1] = ReadData("Введите координату Y точки B");
// b[2] = ReadData("Введите координату Z точки B");

// double result = Distance(a[0], a[1], a[2], b[0], b[1], b[2]);
// System.Console.WriteLine($"Расстояние между точками: {result}");

// // Задача 23
// // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// // 3 -> 1, 8, 27
// // 5 -> 1, 8, 27, 64, 125

// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void NumbersPow(int number)
// {
    
//     for (int i = 1; i <= number; i++)
//     {
//         double result = Math.Pow(i, 3);
//         System.Console.Write($"{result} ");
//     }
// }

// int number = ReadInt("Введите число: ");
// NumbersPow(number);
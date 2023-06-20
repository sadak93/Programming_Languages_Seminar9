// Задача 69: Напишите программу, которая на вход принимает 
// два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int Stepen(int n, int m)
{
    if (m == 0) return 1;
    return n*Stepen(n,m-1);
}

Console.Clear();
System.Console.WriteLine("Введите целое число n");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите целое число m");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Stepen(n,m));

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// int Stepen(int num, int stepen)
// {
//     int sum = 1;
//     int count = 0;
//     while (true)
//     {
//         sum *= num;
//         count++;
//         if (count == stepen)
//             break;
//     }
//     return sum;
// }

// int StepenRec(int num, int stepen)
// {
//     if (stepen == 0) return 1;
//     return num * StepenRec(num, stepen-1);
// }

// Console.Clear();

// System.Console.WriteLine("Введите целое число");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите в какую степень будем его возводить");
// int stepen = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(Stepen(num, stepen));
// System.Console.WriteLine(StepenRec(num, stepen));
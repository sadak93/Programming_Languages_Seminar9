// Задача 67: Напишите программу, которая будет принимать 
// на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int Summ (int num)
{
    if (num == 0) return 0;
    return num%10 + Summ(num/10);
}

Console.Clear();
System.Console.WriteLine("Введите целое число ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Summ(num));

// int Summa(int num)
// {
//     int sum = 0;
//     while (true)
//     {
//         sum += num % 10;
//         num /= 10;
//         if (num == 0)
//             break;
//     }
//     return sum;
// }

// int SummaRec(int num)
// {
//     if (num == 0)  return 0;
//     return num % 10 + SummaRec(num / 10);
// }

// Console.Clear();
// System.Console.WriteLine("Введите целое число ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Сумма всех целых чисел от 1 до {num} равна {Summa(num)}");
// System.Console.WriteLine($"а если рекурсией то {SummaRec(num)}");
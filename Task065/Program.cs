// Задача 65: Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

string NumTillN (int m, int num)
{
    if (num==m) return $"{m}";
    return NumTillN(m, num-1) + $", {num}";
}

Console.Clear();
System.Console.WriteLine("Введите целое число ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите целое число ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(NumTillN(m, num));

// string GetNumbers(int num, int num2)
// {
//     string Numbers = "";
//     while (true)
//     {
//         Numbers = num + " " + Numbers;
//         num--;
//         if (num==num2)
//             break;
//     }
//     return Numbers;
// }

// string GetNumbersRec(int num, int num2)
// {
//     if (num==num2)  return $"{num} ";
//     return GetNumbersRec(num - 1, num2) + num + " ";
// }




// Console.Clear();
// System.Console.WriteLine("Введите целое число начало: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите целое число конец: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Все натуральные от {num2} до {num} равна {GetNumbersRec(num, num2)}");
// Задача 63: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

string NumTillN (int num)
{
    if (num==1) return "1";
    return NumTillN(num-1) + $", {num}";
}

Console.Clear();
System.Console.WriteLine("Введите целое число ");
int num = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(NumTillN(num));

// string GetNumbers(int num)
// {
//     string str = "";
//      while (true)
//     {
//         str = Convert.ToString(num) + " " + str;
//         num--;
//         if (num==0)
//             break;
//     }
//     return str;
// }

// string GetNumbersRec(int num)
// {
//     if (num == 0)  return "";
//     return GetNumbersRec(num - 1) + num + " " ;    
// }

// Console.Clear();

// System.Console.WriteLine("Введите целое число ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(GetNumbersRec(num));
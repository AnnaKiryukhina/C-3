// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число: ");
string? number = Console.ReadLine();

if (number [0] == number[4] || number[1] == number [3])
{
    System.Console.WriteLine("Полиндром");
}
else
{
    System.Console.WriteLine("не является полиндромом");
}




// int Result(int A)
// {
//     int counter = Convert.ToString(A).Length;
//     int sum = 0;
  
//     for ( int i = 0; i < counter; i++)
//     {
//         sum = sum + A % 10;
//         A = A / 10;
//     }

//     return sum;

// }
// int number = ReadInt("Введите число А: ");
// System.Console.WriteLine($"Сумма цифр в числе {number} = { Result (number)}");
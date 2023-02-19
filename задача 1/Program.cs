 int[] coords = new int[2];
 System.Console.Write("Введите X: ");
 coords[0] = Convert.ToInt32(Console.ReadLine());

// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

System.Console.Write("\nВведите Y: ");
coords[1] = Convert.ToInt32(Console.ReadLine());

if (coords[0] > 0 && coords[1] > 0)
{
    System.Console.WriteLine("Мы находимся в первой четверти");
}
else if (coords[0] < 0 && coords[1] > 0)
{
    System.Console.WriteLine("Мы находимся во второй четверти");
}
else if (coords[0] < 0 && coords[1] < 0)
{
    System.Console.WriteLine("Мы находимся в третьей четверти");
}
else if (coords[0] > 0 && coords[1] < 0)
{
    System.Console.WriteLine("Мы находимся в четвертой четверти");
}
else
{
    System.Console.WriteLine("Координата лежит на осях");
}

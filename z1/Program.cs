Console.WriteLine("Найти кубы чисел от 1 до N");
Console.Write("Введите число: ");
int nn = int.Parse(Console.ReadLine() ?? "");
for (int i = 1; i <= nn; i++)
{
    Console.WriteLine($"Куб числа {i} = {i * i * i}");

}
Console.WriteLine($"Это кубы чисел от 1 до {nn}");

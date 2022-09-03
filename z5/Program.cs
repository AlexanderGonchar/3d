Console.WriteLine("Показать кубы чисел, заканчивающихся на четную цифру");
Console.Write("Введите число: ");
int z = int.Parse(Console.ReadLine() ?? "");
if (z % 2 == 0)
{
    Console.WriteLine($"Число {z} заканчивается на четную цифру и его куб будет = {z * z * z}");
}
else
{
    Console.WriteLine($"Число {z} не заканчивается на четную цифру");
}

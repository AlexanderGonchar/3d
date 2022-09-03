Console.WriteLine("Возведите число А в натуральную степень B используя цикл");
Console.Write("Введите число A: ");
int aa = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите число B: ");
int bb = int.Parse(Console.ReadLine() ?? "");
int c = 1;
for (int i = 1; i <= bb; i++)
{
    c = c * aa;
}
Console.WriteLine($"{aa} в степени {bb} = {c}");

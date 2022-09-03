Console.WriteLine("Подсчитать сумму цифр в числе");
Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine() ?? "");
int y = x;
int num_sum = 0;
for (int i = 1; y > 0; i++)
{
    num_sum = num_sum + y % 10;
    y = y / 10;
}
Console.WriteLine($"Сумма цифр в числе {x} = {num_sum}.");

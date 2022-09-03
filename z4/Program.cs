Console.Clear();
Console.WriteLine("Введите число, для вычисления произведения чисел от 1 до N");
int a = Convert.ToInt32(Console.ReadLine());
int b = 1;
int c = 1;
while(a>0)
{
    b=a%10;
    a=a/10;
    c=c*b;
}

Console.WriteLine(c);

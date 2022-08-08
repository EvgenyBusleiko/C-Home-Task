Console.WriteLine("Введите первое число");
int a = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine("Введите второе число");
int b =Convert.ToInt32 (Console.ReadLine ());
if (a<b)
{
    Console.WriteLine($"Максимум число {b}");
}
else if (a==b)
{
    Console.WriteLine("Числа равны");
}
else Console.WriteLine($"Максимум число {a}");

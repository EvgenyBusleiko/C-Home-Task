Console.WriteLine("Введите первое число");
int a = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine("Введите второе число");
int b =Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine("Введите третье число");
int c = Convert.ToInt32 (Console.ReadLine ());
int max=a;

if (max<b) max=b; 
if (max<c) max=c;
if (a==b && b==c)
{
    Console.WriteLine($"Все числа одинаковые");
}
else Console.WriteLine($"Максимум число {max}");

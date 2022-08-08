Console.WriteLine("Введите целое число");
int a = Convert.ToInt32 (Console.ReadLine ());
if (a%2==0)
{
    Console.WriteLine($"{a} это четное число");
}
else  Console.WriteLine($"{a} это нечетное число");

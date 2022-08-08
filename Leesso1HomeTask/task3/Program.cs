Console.WriteLine("Введите целое число");
int N = Convert.ToInt32 (Console.ReadLine ());
for (int i = 1; i < N+1; i++)
{
    if (i%2==0)
    {
        Console.WriteLine (i);
    }
}
Console.WriteLine();
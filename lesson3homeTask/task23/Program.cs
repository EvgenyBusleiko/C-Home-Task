Console.Clear ();
Console.Write ("Введите целое число : ");
int N = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ($" X | X^3",3);
Console.WriteLine("_____________");
for (int i = 1; i < N+1; i++)
{
    Console.WriteLine ($"{i,3}|{i*i*i,3}");
}
Console.WriteLine();

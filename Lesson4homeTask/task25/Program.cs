Console.Clear ();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32 (Console.ReadLine ());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32 (Console.ReadLine ());

int Degree (int ad, int bd)
{
    int mult=1;
    for (int i = 1; i <= b; i++)
    {
        mult=mult*a;
    
    }
    return mult;
}   
int multpl =Degree (a,b);
Console.WriteLine ($"Число {a} в степени {b} = {multpl}");

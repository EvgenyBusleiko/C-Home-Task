Console.Write ("Введите целое число :");
int digit = Convert.ToInt32 (Console.ReadLine ());
if (digit<100) Console.Write ("У числа нет третьей цифры");
else 
{
while (digit>999)
    {
        digit=digit/10;    //Отбрасываем все цифры с конца до 3-ей
    }
digit=digit%10; // отделяем 3-ю
Console.WriteLine (digit);
}

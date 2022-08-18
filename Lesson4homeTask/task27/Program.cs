Console.Clear ();
Console.Write("Введите число: ");
int a = Convert.ToInt32 (Console.ReadLine ());
int AmmountDig (int temp)// определяем количество цифр в числе count
{   
    int amount =0;
    int dig=0;
    while (temp>0)
    {
        dig=temp%10;
        amount=amount+dig;
        temp=temp/10;
          
    }
    return amount;
}

int multpl =AmmountDig (a);
Console.WriteLine ($"Сумма цифр в числе {a} = {multpl}");
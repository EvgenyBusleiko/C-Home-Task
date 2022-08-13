Console.Clear ();
Console.Write ("Введите целое число : ");
int N = Convert.ToInt32 (Console.ReadLine ());

int CountDig (int Np)// определяем количество цифр в числе count
{   
    int count =0;
    while (Np>0)
    {
        Np=Np/10;
        
        count++ ;   
    }
    return count;
}


double Revers (int Np,int count)// переварачиваем число в обратном порядке
{
    double AntiN=0;
    for (int i = count; i >0; i--)
    {
        AntiN=AntiN+(Np%10)*Math.Pow(10,i-1);
        //Console.WriteLine (AntiN);
        Np=Np/10;
   
    }
    return AntiN;
}   
int V=CountDig (N);
//Console.WriteLine (V);
double VersusN=Revers (N,V);
string str=(N==VersusN) ? ("полином") : ("НЕ полином"); // Сравниваем прямое и перевернутое число
Console.WriteLine ($"Число {N} это {str}");




Console.WriteLine ("Введите целое трехзначное число :");
int dig3 = Convert.ToInt32 (Console.ReadLine ());
int dig1 = dig3-dig3/100*100; // Убрал первую цифру
dig1=dig1/10;
Console.WriteLine (dig1); 

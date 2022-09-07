// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 3, n = 2 -> A(m,n) = 29
double Check (string textToPrdouble)
{
    double checkImput=-1;
    do
    {   
        Console.Write($"Введите {textToPrdouble}: ");
        checkImput = Convert.ToDouble(Console.ReadLine());
        if (checkImput<0) Console.WriteLine("Ошибка: Число должно быть положительным! Если хотите выйти введите, пожалуйста '0'");
        else if (checkImput==0) return checkImput=0;
    
    }
    while (checkImput<0);
    return checkImput;

}
double AckermanFunction (double m1,double n1)
{   
    if (m1==0) return n1+1;
    
    else if ((m1 > 0) && (n1 == 0))  return AckermanFunction (m1-1,1);
    
    else  return AckermanFunction(m1-1, AckermanFunction(m1, n1-1));

    // return m1; Вот эта строчка
  
}


Console.WriteLine ("Программу для вычисения функции Анкерманна для значений функции M и N");
double m=Check ("целое положительное число M");
double n=Check ("целое положительное число N");
double ack=AckermanFunction (m,n);
Console.WriteLine ($"Функции Анкерманна для для значений функции {m} и {n} = {ack}");

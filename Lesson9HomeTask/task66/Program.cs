// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int Check (string textToPrint)
{
    int checkImput=-1;
    do
    {   
        Console.Write($"Введите {textToPrint}: ");
        checkImput = Convert.ToInt32(Console.ReadLine());
        if (checkImput<0) Console.WriteLine("Ошибка: Число должно быть положительным! Если хотите выйти введите, пожалуйста '0'");
        else if (checkImput==0) return checkImput=0;
    
    }
    while (checkImput<0);
    return checkImput;

}
int SumofNumber (int num,int end)
{   
    if (num==end) return end;
    if (num<end) end=end+SumofNumber (num, end-1);
    if (num>end) end=end+SumofNumber (num, end+1);

    return end;
    
}


Console.WriteLine ("Программу для суммирования всех натуральных чисел в промежутке от N до M");
int n=Check ("целое положительное число N");
int m=Check ("целое положительное число M");
int sum=SumofNumber (n,m);
Console.WriteLine ($"Сумма чисел в промежутке от {n} до {m} = {sum}");

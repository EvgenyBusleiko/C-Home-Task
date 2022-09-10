// 2. Задача на разворот числа:
// Дано число multpl, десятичная запись которого не содержит нулей.
//  Получите число, записанное теми же цифрами, но в противоположном порядке.

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
int Reverse (int num,int multpl)
{
    
    if (num<10) return 10*multpl+num;
    return Reverse (num/10,10*multpl+num%10);
       
}


Console.WriteLine ("Программа для разворота числа с помощью рекурсии");
int number=Check ("целое положительное число");
int revers=Reverse (number,0);
Console.WriteLine ($"{number} -> {revers}"); 
// Задача 64: Задайте значение N.
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

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
void NaturalNumber (int num)
{
    if (num==0) return;
    if (num!=1) Console.Write ($"{num}, ");
    else Console.Write ($"{num}");
    NaturalNumber (num-1);
    
}


Console.WriteLine ("Программу для вывода всех натуральных чисел в промежутке от N до 1");
int number=Check ("целое положительное число");
NaturalNumber (number);
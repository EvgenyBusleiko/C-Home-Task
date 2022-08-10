int digit = -1;

do
{ 
    Console.Write ("Введите номер дня недели от 1 до 7:");
    digit = Convert.ToInt32 (Console.ReadLine ());
    if (digit<0 || digit>7) Console.WriteLine ("Нужно ввести число от 1 до 7 или 0 для выхода.");
    
} while (digit<0 || digit>7);
if (digit!=0)
{
     string str= ((digit==7) || (digit==6 )) ? str ="выходной" : str="рабочий";
    Console.WriteLine ($"{digit} это {str} день");
}

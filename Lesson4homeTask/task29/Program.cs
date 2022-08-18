Console.Clear ();
int [] RandArray (int len)
{
    int []arraytemp=new int[len];
    for (int i = 0; i < len; i++)
    {
        arraytemp[i]=new Random().Next(0,100);
    }
    return arraytemp;
}   
void PrintArray (int [] res, int len)
{   Console.Write ("[");
    for (int i = 0; i < len-1; i++)
        {
        Console.Write ($"{res[i]},");
        }
        Console.WriteLine ($"{res[len-1]}]");
}
Console.Write("Введите количество элементов массива ");
int a = Convert.ToInt32 (Console.ReadLine ());
if (a==0) Console.WriteLine("Пустой массив");
    
else
{
    int [] result= RandArray (a);
    PrintArray (result,a);
}
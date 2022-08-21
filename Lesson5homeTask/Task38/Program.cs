// Задача 38: 
// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
double[] CreateArrayRndDouble(int size)
{
	
	Random rnd = new Random();
	double[] array = new double[size];
	for (int i = 0; i < size; ++i)
	{
		array[i] =Math.Round (rnd.NextDouble()*100,1,MidpointRounding.ToEven);
	}

	return array;
}

int [] FindMinMax (double[] array)
{
    double max=array[0];
    double min=array[0];
    int [] maxmin=new int [2];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i]>max) 
        {
            max=array[i];
            maxmin[0]=i;
            
        }
        else if (array[i]<min)
        {
            min=array[i];
            maxmin[1]=i;
        } 
    }
    
	return maxmin;
}

void PrintArray(double[] array,int[] indexArr)
{
	
	Console.Write("[");
	for (int i = 0; i < array.Length - 1; i++)
	{
		
       if (i==indexArr[0])
       {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"{array[i]} |  ");
        Console.ResetColor();
       }   
       else if (i==indexArr[1])
       {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write($"{array[i]} |  ");
        Console.ResetColor();
       }   
       else Console.Write($"{array[i]} |  ");
	    
    }
	
    if ((array.Length-1)==indexArr[0])
       {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"{array[array.Length - 1]}]");
        Console.ResetColor();
       }   
       else if ((array.Length-1)==indexArr[1])
       {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write($"{array[array.Length - 1]}]");
        Console.ResetColor();
       }   
       else Console.Write($"{array[array.Length - 1]}]");
    Console.WriteLine ();
}

Console.Clear ();
Console.Write("Введите число элементов массива: ");
int qty = Convert.ToInt32(Console.ReadLine());
if (qty <= 0) Console.WriteLine("Ошибка: Число элементов должно быть больше нуля!");
else

{	
double[] arr = CreateArrayRndDouble(qty);

int [] result = FindMinMax (arr);
PrintArray(arr,result);
double diff= Math.Round ((arr[result[0]]-arr[result[1]]),1,MidpointRounding.ToEven);
Console.WriteLine($"Разность максимального и минимального элемента = {diff}");

}

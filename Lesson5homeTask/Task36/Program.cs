// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях (индексах).

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
int[] CreateArrayRndInt(int size)
{
	if (size == 0)
		return new int[] { };

	Random rnd = new Random();
	int[] array = new int[size];
	for (int i = 0; i < size; ++i)
	{
		array[i] = rnd.Next(-100, 101);
	}

	return array;
}

int CountSumNegIndex (int[] array)
{
    int sum=0;
    Console.Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        if (i%2!=0)
        {
            sum=sum+array[i];
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{array[i]}, ");
            Console.ResetColor();
        }
        else Console.Write($"{array[i]}, ");
    }
    if ((array.Length - 1)%2!=0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($"{array[array.Length - 1]}]");
        Console.ResetColor();
        sum=sum+array[array.Length - 1];
    }
    else Console.Write($"{array[array.Length - 1]}]");
    Console.WriteLine ();

	return sum;
}

// void PrintArray(int[] array)
// {
	
// 	Console.Write("[");
// 	for (int i = 0; i < array.Length - 1; i++)
// 	{
// 		if (i%2!=0)
//         {   Console.ForegroundColor = ConsoleColor.Green;
//             Console.Write($"{array[i]}, ");
//             Console.ResetColor();
// 	    }
//         else Console.Write($"{array[i]}, ");
//     }
// 	if (array.Length - 1%2!=0)
//     {
//         Console.ForegroundColor = ConsoleColor.Green;
//         Console.Write($"{array[array.Length - 1]}]");
//         Console.ResetColor();
//     }
//     else Console.Write($"{array[array.Length - 1]}]");
//     Console.WriteLine ();
// }

Console.Clear ();
Console.Write("Введите число элементов массива: ");
int qty = Convert.ToInt32(Console.ReadLine());
if (qty <= 0) Console.WriteLine("Ошибка: Число элементов должно быть больше нуля!");
else

{	
int[] arr = CreateArrayRndInt(qty);
// PrintArray(arr);
int result = CountSumNegIndex (arr);
Console.WriteLine($"Сумма элементов массива с нечетными индексами = {result}");

}

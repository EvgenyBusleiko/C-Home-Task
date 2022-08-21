// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// // [345, 897, 568, 234] -> 2

// Methods

int[] CreateArrayRndInt(int size)
{
	
	Random rnd = new Random();
	int[] array = new int[size];
	for (int i = 0; i < size; ++i)
	{
		array[i] = rnd.Next(100, 1000);
	}

	return array;
}

int CountPos (int[] array)
{
    int count=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2==0) ++count;
    }

	return count;
}

void PrintArray(int[] array)
{
	
	Console.Write("[");
	for (int i = 0; i < array.Length - 1; i++)
	{
		if (array[i]%2==0)
        {   Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{array[i]}, ");
            Console.ResetColor();
	    }
        else Console.Write($"{array[i]}, ");
    }
	if (array[array.Length - 1]%2==0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
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
int[] arr = CreateArrayRndInt(qty);
PrintArray(arr);
int result = CountPos (arr);
Console.WriteLine($"Колличество четных элементов массива = {result}");

}



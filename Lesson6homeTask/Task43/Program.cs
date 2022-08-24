Console.Clear ();

Console.WriteLine("Программа для поиска координат точки пересечения двух функций вида y=kХ+b ");
Console.WriteLine();
Console.Write("Введите коэффициент k первой фунции: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициент b первой фунции: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициент k второй фунции: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициент b второй фунции: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double x=((b2-b1)/(k1-k2));
double y=k1*x+b1;
Console.WriteLine ($"Функции пересекутся в точке с координатами ({x};{y})");
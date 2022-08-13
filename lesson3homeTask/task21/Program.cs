Console.Clear ();
Console.WriteLine ("Введите координаты точек");
Console.WriteLine ("Первая точка Х,У,Z: ");
int x1 = Convert.ToInt32 (Console.ReadLine ());
int y1 = Convert.ToInt32 (Console.ReadLine ());
int z1 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Вторая точка Х,У,Z ");
int x2 = Convert.ToInt32 (Console.ReadLine ());
int y2 = Convert.ToInt32 (Console.ReadLine ());
int z2 = Convert.ToInt32 (Console.ReadLine ());

double GetDistance (int xc1, int yc1,int zc1, int xc2,int yc2, int zc2)
{
    double result = Math.Sqrt ((xc1-xc2)*(xc1-xc2)+(yc1-yc2)*(yc1-yc2)+(zc1-zc2)*(zc1-zc2));
    return result;
}

double distance= Math.Round(GetDistance (x1,y1,z1,x2,y2,z2),2);
Console.WriteLine ($"Расстояние между точками равно {distance}");
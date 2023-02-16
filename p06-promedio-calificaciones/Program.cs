﻿// Calcula el promedio de tres calificaciones, calcula también la mayor y la menor

float cal1, cal2, cal3, suma, prom, mayor, menor;
cal1 = cal2 = cal3 = 0;

Console.WriteLine("Calcula el promedio de tres calificaciones, calcula también la mayor y la menor\n");
Console.Write("Calificación 1 : "); cal1 = float.Parse(Console.ReadLine());
Console.Write("Calificación 2 : "); cal2 = float.Parse(Console.ReadLine());
Console.Write("Calificación 3 : "); cal3 = float.Parse(Console.ReadLine());

suma = cal1 + cal2 + cal3;
prom = suma / 3;
mayor = Math.Max( Math.Max(cal1, cal2) , cal3 );
menor = Math.Min( Math.Min(cal1, cal2) , cal3 );

Console.WriteLine($"Las calificaciones : {cal1}, {cal2}, {cal3}");
Console.WriteLine($"La suma      : {suma:f2}");
Console.WriteLine($"El promedio  : {prom:f2}");
Console.WriteLine($"La mayor     : {mayor:f2}");
Console.WriteLine($"La menor     : {menor:f2}");





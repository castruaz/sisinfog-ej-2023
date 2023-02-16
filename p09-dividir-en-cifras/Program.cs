// Dividir un número de 3 cifras en C D U

double centenas, decenas, unidades, num;

Console.Clear();
Console.WriteLine("Dividir un número de 3 cifras en C D U\n");

num = 425;

centenas =  Math.Truncate( num / 100 );
decenas  =  Math.Truncate( ( num - (centenas * 100) ) / 10 );
unidades =  num - (centenas * 100 + decenas * 10);

Console.WriteLine($"Centenas : {centenas}");
Console.WriteLine($"Decenas  : {decenas}");
Console.WriteLine($"Unidades : {unidades}");
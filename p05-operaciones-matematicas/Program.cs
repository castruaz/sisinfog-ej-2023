// Efectua operaciones matemáticas básica con dos números

double suma, resta, multi, divi, resi, pote;
double x = 10.5, y = 2.5;

Console.Clear();
Console.WriteLine("Efectua operaciones matemáticas básica con dos números\n");

suma = x + y;
resta = x - y;
multi = x * y;
divi = x / y;
resi = x % y;
pote = Math.Pow(x,y);

Console.WriteLine($"Los numeros son: {x}, {y}");
Console.WriteLine($"Suma           : {suma}");
Console.WriteLine($"Resta          : {resta}");
Console.WriteLine($"Multiplicación : {multi}");
Console.WriteLine($"Divisón        : {divi}");
Console.WriteLine($"Residuo        : {resi}");
Console.WriteLine($"Potencia       : {pote}");
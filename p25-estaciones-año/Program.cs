// Muestra la estación del año que corresponde al número (1..4)

Console.Clear();
Console.WriteLine("Muestra la estación del año que corresponde al número (1..4)\n");
Console.Write("Dame un número dentre 1 y 4 ? ");
int n = int.Parse(Console.ReadLine());

if( n>=1 && n<=4) {
    if(n==1) Console.WriteLine("Primavera\n");
    if(n==2) Console.WriteLine("Verano\n");
    if(n==3) Console.WriteLine("Otoño\n");
    if(n==4) Console.WriteLine("Invierno\n");
} else Console.WriteLine("\nEn que planeta vives ???");
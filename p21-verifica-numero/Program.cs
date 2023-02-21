// Verifica si un número es positivo, negativo o cero

int n;
Console.Clear();
Console.WriteLine("Verifica si un número es positivo, negativo o cer\n");
Console.Write("Dame un número ? ");
n = int.Parse(Console.ReadLine());

if(n>0) Console.WriteLine("El número es positivo ..");

if(n<0) Console.WriteLine("El número es negativo ..");

if(n==0) Console.WriteLine("El número es cero ..");

Console.WriteLine("\nGracias por utilizar este super programa");
// Verifica si la suma de dos números es igua a un tercer número

int n1, n2, n3;

Console.Clear();
Console.WriteLine("Verifica si la suma de dos números es igua a un tercer número\n");
Console.Write("Dame el primer número  ? "); n1 = int.Parse(Console.ReadLine());
Console.Write("Dame el segundo número ? "); n2 = int.Parse(Console.ReadLine());
Console.Write("Dame el terce número   ? "); n3 = int.Parse(Console.ReadLine());

if( n1 + n2 == n3 ) 
    Console.WriteLine("Son iguales ");
else
    Console.WriteLine("Son diferentes");

Console.WriteLine("\nGracias por utilizar este programa...");
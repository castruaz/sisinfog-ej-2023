// Acepta a un estudiante en base a su edad y sus calificaciones

Console.Clear();
Console.WriteLine("\nAcepta a un estudiante en base a su edad y sus calificaciones");
Console.Write("Dame tu nombre ? ");
string nombre = Console.ReadLine();
Console.Write("Dame la edad ? ");
int edad = int.Parse(Console.ReadLine());

if( edad < 18 ) Console.WriteLine("\nNo aceptamos menores de edad , BYE");
else {
    Console.Write("Calificacion 1 ? "); float c1 = float.Parse(Console.ReadLine());
    Console.Write("Calificacion 2 ? "); float c2 = float.Parse(Console.ReadLine());
    if( c1<8 || c2<8 ) Console.WriteLine("\nNo aceptamos con calificaciones menor a 8");
    else {
        Console.WriteLine($"BIENVENIDO {nombre} tienes {edad} y calficaciones {c1} y {c2}");
    }
}
Console.WriteLine("\nGracias por participar");
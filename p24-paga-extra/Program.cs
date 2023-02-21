// Calcula la paga extra de un trabajador, jordnada de 40 horas

string nombre;
int horas, extra;
float paga, total;

Console.Clear();
Console.WriteLine("Calcula la paga extra de un trabajador, jordnada de 40 horas\n");
Console.Write("Dame tu nombre              ? "); nombre = Console.ReadLine();
Console.Write("Cuantas horas trabajaste    ? "); horas = int.Parse(Console.ReadLine());
Console.Write("A cuanto te pagaron la hora ? "); paga = float.Parse(Console.ReadLine());

if( horas>40 ) {
    extra = horas - 40;
    total = 40 * paga +  ( extra * paga * 2);
    Console.WriteLine($"Horas extra: {extra} , pagadas a {paga*2}");
} else 
    total = horas * paga;

Console.WriteLine($"Pago total : {total:n2}");

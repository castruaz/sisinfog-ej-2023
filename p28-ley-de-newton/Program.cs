// Calcula fuerza, masa o aceleración según la ley de newton

float f, m, a;

Console.Clear();
Console.WriteLine("Calcula fuerza, masa o aceleración según la ley de newton:\n");
Console.WriteLine("[F]uerza      f=m*a");
Console.WriteLine("[M]asa        m=f/a");
Console.WriteLine("[A]celeración a=f/m");
Console.Write("Elije una opción ? ");
char op = char.ToUpper(Console.ReadLine()[0]);

f=m=a=0;

if( op=='F') {
    Console.WriteLine("Calculando la fuerza ...");
    Console.Write("Masa        ? "); m = float.Parse(Comsole.ReadLine());
    Console.Write("Aceleración ? "); a = float.Parse(Comsole.ReadLine());
    f = m * a;
    Console.WriteLine($"La fuerza es {f}");
} else if( op=='M') {
    Console.WriteLine("Calculando la masa ...");
    Console.Write("Fueza       ? "); f = float.Parse(Comsole.ReadLine());
    Console.Write("Aceleración ? "); a = float.Parse(Comsole.ReadLine());
    m = f / a;
    Console.WriteLine($"La masa es {m}");
} else if( op== 'A') {
    Console.WriteLine("Calculando la aceleración ...");
    Console.Write("Fueza       ? "); f = float.Parse(Comsole.ReadLine());
    Console.Write("Masa        ? "); m = float.Parse(Comsole.ReadLine());
    a= f / m;
    Console.WriteLine($"La aceleración es {a}");

} else Console.WriteLine("\nOpción Inválida x  ");

Console.WriteLine("\nProceso terminado");
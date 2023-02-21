// Convertir temperatura de grados celcius a farnheit y vicersa

char op;
float temp, res;

Console.Clear();
Console.WriteLine("Convertir temperatura de grados celcius a farnheit y vicersa\n");
Console.WriteLine("[F]arnheit   ");
Console.WriteLine("[C]entigrados");
Console.Write("Elige una opción ? ");
op =  char.ToUpper( Console.ReadLine()[0] );

if(op=='F') {
    Console.WriteLine("Conviritiendo a Farenheit ..");
    Console.Write("Dame los grados celcius ?"); temp=float.Parse(Console.ReadLine());
    res =  (temp * 9 / 5) + 32;
    Console.WriteLine($"{temp} celcius, equivale a {res} farenheit");
} else {
    Console.WriteLine("Conviritiendo a Centigrados ..");
    Console.Write("Dame los grados farenheit ?"); temp=float.Parse(Console.ReadLine());
    res =  (temp - 32) * 5/9;
    Console.WriteLine($"{temp} farenheit, equivale a {res} centigrados");
}

Console.WriteLine("\nGracias por utilizar este programa");
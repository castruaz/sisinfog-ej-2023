// Utiliza los operadores de asignación para efectuar diversas operaciones 

Console.Clear();
Console.WriteLine("Utiliza los operadores de asignación para efectuar diversas operaciones\n");

Console.Write("Dame un número ? ");
float num = float.Parse(Console.ReadLine());

Console.WriteLine($"El número es : {num}");
Console.WriteLine($"Incrementar en 1   : { ++num }");
Console.WriteLine($"Sumar 50           : { num+=50 }");
Console.WriteLine($"Restar 35          : { num-=35 }");
Console.WriteLine($"Multiplicar por 15 : { num*=15 }");
Console.WriteLine($"Dividir entr 4     : { num/=4 }");
Console.WriteLine($"Decrementar en 1   : { --num }");


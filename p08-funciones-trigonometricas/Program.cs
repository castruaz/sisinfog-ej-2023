// Calcula las funciones trigonometricas básicas de un angulo en radianes

Console.Clear();
Console.WriteLine("Calcula las funciones trigonometricas básicas de un angulo en radianes:\n");

Console.Write("Dame un angulo en radianes: ");
double angulo = double.Parse(Console.ReadLine());

Console.WriteLine($"El angulo {angulo}, tiene las siguientes funciones trigonometricas:\n");

Console.WriteLine("Seno {0:f4} , Coseno {1:f4}, Tangente {2:f4}", Math.Sin(angulo), Math.Cos(angulo), Math.Tan(angulo));


// Muestra el tipo de angulo según los grados

Console.Clear();
Console.WriteLine("Muestra el tipo de angulo según los grados:\n");
Console.Write("Dame un angulo entre 0 y 360 grados ? ");
int angulo = int.Parse(Console.ReadLine());

if(angulo<0 || angulo>360) Console.WriteLine("Angulo inválido ...");
else {
    if(angulo==0) Console.WriteLine("El angulo es NULO ..");
    if(angulo>0 && angulo<90) Console.WriteLine("El angulo es AGUDO ..");
    if(angulo==90) Console.WriteLine("El angulo es RECTO ..");
    if(angulo>90 && angulo<180) Console.WriteLine("El angulo es OBTUSO ..");
    if(angulo==180) Console.WriteLine("El angulo es LLANO ..");
    if(angulo>180 && angulo<360) Console.WriteLine("El angulo es CONCAVO ..");
    if(angulo==360) Console.WriteLine("El angulo es COMPLETO ..");
} 
Console.WriteLine("\nProceso terminado ...");
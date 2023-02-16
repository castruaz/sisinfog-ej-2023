﻿// Trabajando con números enteros

int num1 = 42;
int num2 = 0x2A;
int num3 = 0b00101010;

Console.Clear();
Console.WriteLine($"Decimal {num1} {num2} {num3}");
Console.WriteLine($"num1 en base 10: {num1}");
Console.WriteLine($"num1 en base 8: {Convert.ToString(num1,8)}");
Console.WriteLine($"num1 en base 16: {Convert.ToString(num1,16)}");
Console.WriteLine($"num1 en base 2: {Convert.ToString(num1,2)}");

sbyte edad = 95;
byte val1 = 230, val2=254;
short horas=24, dias=12345;
long ganancia=23131231232132123;
ulong añosluz=12312312321344444441;

Console.WriteLine($"La ganancia anual : {ganancia:c}");
Console.WriteLine($"Años Luz a la luna: {añosluz:e}");
Console.WriteLine($"num2 base dec,hex : {num2:d} , {num2:x}");

Console.WriteLine($"sbyte : {sbyte.MinValue},  {sbyte.MaxValue}");
Console.WriteLine($"byte  : {byte.MinValue},  {byte.MaxValue}");
Console.WriteLine($"int  : {int.MinValue},  {int.MaxValue}");
Console.WriteLine($"short  : {short.MinValue},  {short.MaxValue}");
Console.WriteLine($"long  : {long.MinValue},  {long.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue},  {ulong.MaxValue}");

Console.WriteLine($"bytes int  : {sizeof(int)} ");
Console.WriteLine($"ulong int  : {sizeof(ulong)} ");
// São tipos por valor e dão suporte a operadores aritméticos de comparação e de igualdade

Console.WriteLine("Declarando variáveis numéricas");
Console.WriteLine();

// Declarando variáveis
byte valorB1 = 255;
Console.WriteLine(valorB1);
System.Byte valorB2 = 200;
Console.WriteLine(valorB2);

sbyte valorSB1 = -127;
Console.WriteLine(valorSB1);
System.SByte valorSB2 = -127;
Console.WriteLine(valorSB2);


int valorI1 = -2147483647;
Console.WriteLine(valorI1);
System.Int32 valorI2 = -2147483647;
Console.WriteLine(valorI2);

valorI2 = 1000;

const int naoMudaValor = 25;
Console.WriteLine("Constante => "+ naoMudaValor);

uint valoUI1 = 2147483647;
Console.WriteLine(valoUI1);
System.UInt32 valorUI2 = 2147483647;
Console.WriteLine(valorUI2);

long valorL1 = -21474836489;
Console.WriteLine(valorL1);
System.Int64 valorL2 = -21474836489;
Console.WriteLine(valorL2);


Console.ReadLine();
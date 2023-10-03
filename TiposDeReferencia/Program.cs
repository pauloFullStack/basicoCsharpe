/*
 * - São tipos de referência
 * - O valor padrão é null
 */
Console.WriteLine("Definindo variaveis do tipo string e object e dynamic");



// Tipo STRING
string nome1 = "Curso Csharp Essencial - alias";
Console.WriteLine(nome1);
// System.String é o tipo .NET
System.String nome2 = "Curso Csharp Essencial - Tipo .NET";
Console.WriteLine(nome2);



/*
 * Tipo OBJECT e DYNAMIC
 * Com o OBJECT e DYNAMIC eu posso usar qualquer tipo eu não sabia :)
 */

// tipo INT usando object
object nota = 1;
Console.WriteLine($"tipo INT usando object alias -> {nota}");
dynamic nota1 = 2;
Console.WriteLine($"tipo INT usando dynamic alias -> {nota1}");
System.Object nota2 = 3;
Console.WriteLine($"tipo INT usando object e o tipo .NET -> {nota2}");


// tipo DECIMAL usando object
object valor = 1.55m;
Console.WriteLine($"tipo DECIMAL usando object alias -> {valor}");
dynamic valor1 = 2.55m;
Console.WriteLine($"tipo DECIMAL usando dynamic alias -> {valor1}");
System.Object valor2 = 3.55m;
Console.WriteLine($"tipo DECIMAL usando object e o tipo .NET -> {valor2}");


// tipo STRING usando object
object nomeObj = "String alias";
Console.WriteLine($"tipo STRING usando object alias -> {nomeObj}");
dynamic nomeObj1 = "String dynamic";
Console.WriteLine($"tipo STRING usando dynamic alias -> {nomeObj1}");
System.Object nomeObj2 = "String .NET";
Console.WriteLine($"tipo STRING usando object e o tipo .NET -> {nomeObj2}");


// tipo BOOL usando object
object boolObj = true;
Console.WriteLine($"tipo BOOL usando object alias -> {boolObj}");
dynamic boolObj1 = false;
Console.WriteLine($"tipo BOOL usando dynamic alias -> {boolObj1}");
System.Object boolObj2 = false;
Console.WriteLine($"tipo BOOL usando object e o tipo .NET -> {boolObj2}");

// tipo CHAR usando object
object charObj = 'A';
Console.WriteLine($"tipo CHAR usando object e alias -> {charObj}");
dynamic charObj1 = 'B';
Console.WriteLine($"tipo CHAR usando dynamic e alias -> {charObj1}");
System.Object charObj2 = 'C';
Console.WriteLine($"tipo CHAR usando object e o tipo .NET -> {charObj2}");


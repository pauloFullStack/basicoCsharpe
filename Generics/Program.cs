/* Generics - Conceito 
 * 
 * 
 * A palavra 'Generics' significa a forma geral e não a forma específica
 * 
 * Na linguagem C# 'Generics' significa não ser específico para um determinado tipo de dados
 * 
 * A linguagem C# permite definir classes, interfaces, campos, métodos, propriedades, eventos,
 * delegates e operadores 'genéricos' usando o 'parâmetro de tipo' e sem o tipo de dados 
 * específico
 * 
 * O recurso 'Generics' permite que classes, métodos e interfaces possam ser parametrizados por tipo
 * 
 * Já utilizamos o recurso 'Generics' quando tratamos das coleções List<int>, List<string> e List<object>
 * 
 */


/* Generics - Sintaxe 
 * 
 * 
 * Um tipo genérico é declarado especificando um parâmetro de tipo entre colchetes angulares (<T>) após
 * um nome de tipo, Ex:
 * 
 * NomeTipo<T> onde T é o parâmetro de tipo
 * 
 */


/* Generics - restrições(constraints)
 * 
 * 
 * Podemos também definir 'restrições' para restringir o código do cliente para especificar determinados
 * tipos ao instanciar tipo genéricos.
 * 
 * Podemos definir uma ou mais restrições no tipo genérico usando a cláusula 'where' após o nome do 
 * tipo genérico seguido de dois pontos e a seguir a restrição que desejamos definir, Ex:
 * 
 * NomeTipo<T> where T : <restrição>
 * 
 * 
 */


/* Generics - Benefícios 
 * 
 * 
 * Os principais benefícios do 'Generics' são:
 * 
 * 1 - Reutilização de código
 * 2 - Segurança de tipo(Type Safety)
 * 3 - Desempenho(evita as operações e boxing e unboxing)
 * 
 * Generics é usado para definir as coleções genéricas no namespace System.Collection.Generic
 * 
 * - Collection<T>
 * - List<T>
 * - Dictionary<Tkey, Tvalue>
 * - Queue<T>
 * - Stack<T>
 */


Teste teste = new Teste();

int i1 = 10;
int i2 = 10;

float f1 = 10;
float f2 = 10;

string s1 = "10";
string s2 = "10";

teste.CompararUmTipo(i1, i2);
teste.CompararUmTipo(f1, f2);
teste.CompararUmTipo(s1, s2);

teste.CompararDoisTipo(i1, i2);
teste.CompararDoisTipo(f1, i2);
teste.CompararDoisTipo(s1, s2);



Teste1<int, int> teste1 = new Teste1<int,int>();
Teste1<float, float> teste2 = new Teste1<float, float>();
//Teste1<string, string> teste3 = new Teste1<string, string>();

int i11 = 10;
int i22 = 10;

float f11 = 10;
float f22 = 10;

string s11 = "10";
string s22 = "10";

teste1.CompararUmTipo(i11, i22);
teste1.CompararUmTipo(f11, f22);
teste1.CompararUmTipo(s11, s22);

teste1.CompararDoisTipo(i11, i22);
teste2.CompararDoisTipo(f11, f22);
//teste3.CompararDoisTipo(s11, s22);


Console.ReadKey();

public class Teste
{


    public void CompararUmTipo<T>(T p1, T p2)
    {
        Console.WriteLine($"Os tipos : {p1.GetType()} e {p2.GetType()} ");
        var resultado = p1.Equals(p2);
        Console.WriteLine($"{p1} e {p2} são iguais ? {resultado}\n");
    }

    public void CompararDoisTipo<T1, T2>(T1 p1, T2 p2)
    {
        Console.WriteLine($"Os tipos : {p1.GetType()} e {p2.GetType()} ");
        var resultado = p1.Equals(p2);
        Console.WriteLine($"{p1} e {p2} são iguais ? {resultado}\n");
    }

}


/* OU DESSA OUTRO FORMA ABAIXO */

/* struct referece a tipo de valor, class a tipo de referencia, no caso abaixo os tipos T1 e T2 so aceitam tipos de valor */
public class Teste1<T1, T2> where T1 : struct where T2: struct
{


    public void CompararUmTipo<T>(T p1, T p2)
    {
        Console.WriteLine($"Os tipos : {p1.GetType()} e {p2.GetType()} ");
        var resultado = p1.Equals(p2);
        Console.WriteLine($"{p1} e {p2} são iguais ? {resultado}\n");
    }

    public void CompararDoisTipo(T1 p1, T2 p2)
    {
        Console.WriteLine($"Os tipos : {p1.GetType()} e {p2.GetType()} ");
        var resultado = p1.Equals(p2);
        Console.WriteLine($"{p1} e {p2} são iguais ? {resultado}\n");
    }

}
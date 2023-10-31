/* LINQ - Operadores de quantificação 
 * 
 * São usados em uma fonte de dados quando queremos verificar se alguns ou todos os elmentos atendem a uma condição ou não.
 * 
 * Eles retornam um valor booleano(true ou false) que indica se alguns ou todos os elementos na fonte de dados satisfazem
 * a condição.
 *
 * All - Determina se todos os elementos da fonte de dados satisfaz uma condição, retorna true se cada elemento da sequência passar
 * no teste especificado no predicado ou se a sequência estiver vazia; caso contrário retorna false.
 * 
 * Any - Determina se pelo menos um dos elementos da fonte de dados satisfaz uma condição, determina se qualquer elemento da sequência
 * (verifica o tamanho da sequência) ou se satisfaz uma condição
 * 
 * Contains - Determna se a fonte de dados contém um elemento especificado, verifica se a coleção contém um elemento especificado ou não.
 * Se contiver retorna true, caso contrário retorna false(System.Linq)
 * 
 */



/*---------------- All ----------------*/

using LINQOperadoresDeQuantificacao;

int[] numeros = { 10, 22, 32, 44, 56, 64, 78 };
var resultado1 = numeros.All(x => x % 2 == 0);
Console.WriteLine($"{(resultado1 ? "Todos são pares" : "Nem todos são pares")}");
Console.WriteLine("-------------------------");


var idadeMaiorQue18 = FonteDeDados.GetAlunos();
int idade = 18;
var resultado2 = idadeMaiorQue18.All(a => a.Idade > idade);
Console.WriteLine(resultado2);
Console.WriteLine("-------------------------");


var resultado3 = idadeMaiorQue18.All(a => a.Nome.Contains('a'));
Console.WriteLine(resultado3);
Console.WriteLine("-------------------------");

var pessoas = FonteDeDados.GetPessoas();

/* Sintaxe de consulta */
var nomes = from pessoa in pessoas
            where pessoa.Cachorros.All(pet => pet.Idade > 5)
            select pessoa.Nome;
foreach (var nome in nomes)
    Console.WriteLine(nome);
Console.WriteLine("-------------------------");


/*---------------- Any ----------------*/

var cursos = FonteDeDados.GetCursos();
var existeCursos = cursos.Any();
Console.WriteLine(existeCursos);
Console.WriteLine("-------------------------");


var existeCursosComCaracteresMaiorQue2 = cursos.Any(curso => curso.Length > 2);
Console.WriteLine(existeCursosComCaracteresMaiorQue2);
Console.WriteLine("-------------------------");

/* metodo de consulta */
var existeCursosComCaracteresMaiorQue2Consulta = (from c in cursos
                                                  select c).Any(c => c.Contains('P'));
Console.WriteLine(existeCursosComCaracteresMaiorQue2Consulta);
Console.WriteLine("-------------------------");


List<Cachorro> cachorros = new List<Cachorro>()
{
    new Cachorro() {Nome = "Bilu", Idade = 6, Vacinado = true},
    new Cachorro() {Nome = "Canelinha", Idade = 3, Vacinado = false},
    new Cachorro() {Nome = "Pipoca", Idade = 8, Vacinado = true},
};

var naoVacinados = cachorros.Any(P => P.Idade > 2 && P.Vacinado == false);
Console.WriteLine(naoVacinados);
Console.WriteLine("-------------------------");


var naoVacinados1 = (from c in cachorros
                     select c).Any(p => p.Idade > 3 && p.Vacinado == false);

Console.WriteLine(naoVacinados1);
Console.WriteLine("-------------------------");


/*---------------- Contains ----------------*/

AlunoComparer alunoComparer = new AlunoComparer();

var alunos = FonteDeDados.GetAlunos();
var aluno1 = new Aluno() { Nome = "Maria", Idade = 36 };
/* Para comparar um objeto, tem que implementar os metodos da Interface IEqualityComparer<T> */
var resultado = alunos.Contains(aluno1, alunoComparer);
Console.WriteLine(resultado);
Console.WriteLine("-------------------------");

/* Sintaxe de consulta */
var resultado5 = (from num in alunos
                  select num).Contains(aluno1, alunoComparer);
Console.WriteLine(resultado5);
Console.WriteLine("-------------------------");


Console.ReadKey();


public class AlunoComparer : IEqualityComparer<Aluno>
{
    bool IEqualityComparer<Aluno>.Equals(Aluno? x, Aluno? y)
    {
        if (object.ReferenceEquals(x, y))
            return true;

        if (x is null || y is null)
            return false;

        return x.Nome == y.Nome && x.Idade == y.Idade;
    }

    int IEqualityComparer<Aluno>.GetHashCode(Aluno obj)
    {
        if (obj is null)
            return 0;

        int NomeHashCode = obj.Nome == null ? 0 : obj.Nome.GetHashCode();
        int IdadeHashCode = obj.Idade.GetHashCode();
        return NomeHashCode ^ IdadeHashCode;    

    }
}
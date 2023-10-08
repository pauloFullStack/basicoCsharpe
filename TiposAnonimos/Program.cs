/* Tipos anônimos : conceito
 *  
 * Um tipo anônimo é um tipo (classe) sem nehum nome que pode conter apenas propriedades
 * públicas somente leitura
 * 
 * Os tipos anônimos fornecem uma maneira conveniente para encapsular um conjunto de
 * propriedades somente leitura em um único objeto sem precisar primeiro definir 
 * explicitamente um tipo
 * 
 * 
 * 
 * Inicialização
 * 
 * Um tipo anônimo é inicializado usando o operador 'new', em combinação com um 'inicializador de objetos'.
 * 
 * Como não há nenhuma classe por trás do objeto, você deve usar a palavra-chave 'var' ao recuperar a 
 * referência ao sue objeto
 * 
 * 
 * 
 * Característica
 * 
 * São os tipos de referência que derivam  diretamente de Object.
 * 
 * Contêm uma ou mais propriedades públicas somente leitura.
 * 
 * Nenhum outro tipo de membro de classe, como métodos ou eventos, é válido e a expressão
 * usada para inicializar uma propriedade não pode ser nula, uma função anônima ou 
 * um tipo de ponteiro.
 * 
 * Se dois ou mais tipos anônimos tiverem o mesmo número e tipo de propriedades na mesma
 * ordem, o compilador irá tratá-los como o mesmo tipo e eles compartilham as mesmas informações
 * de tipo gerado pelo compilador.
 * 
 * Sempre será local para o método no qual for definido e não pode ser retornado do método.
 * 
 * Pode ser passado para outro método como parâmetro de tipo de objeto, mas isso não é recomendado
 *
 * Quando usar? Tipos anônimos são normalmente usados em uma cláusula 'Select' de uma expressão de
 * consulta, geralmente com a LINQ, para retornar um subconjunto das propriedades de cada objeto
 * na sequência de origem.
 *
 * */

Console.WriteLine("## Tipos Anônimos ##");


var aluno = new
{
    Name = "Maria",
    Idade = 84
};

Console.WriteLine($"\nNome: {aluno.Name} \nIdade: {aluno.Idade}");

/* Não pode ser alterado os tipos anônimos, por exemplo
 * aluno.Idade = 43
 * */

/* Verifica os tipo dos elementos */
Console.WriteLine(aluno.GetType().ToString());

/* Um tipo anônimo, com outro tipo anônimo atribuido */
var aluno1 = new
{
    Id = 1,
    Nome = "João",
    Email = "paulo@email.com",
    Endereco = new { Id = 1, Cidade = "Santos", Pais = "Brasil" }
};

Console.WriteLine(aluno1.Nome);
Console.WriteLine(aluno1.Endereco.Cidade);


/* Um array de tipos anônimos */
var aluno2 = new[]
{
    new { Id = 1, Nome = "Maria", Email = "maria@email.com", Endereco = new { Id = 1, Cidade = "Santos", Pais = "Brasil" }},
    new { Id = 2, Nome = "Sonia", Email = "sonia@email.com", Endereco = new { Id = 2, Cidade = "Uberlândia", Pais = "Brasil" }},
    new { Id = 3, Nome = "Bruno", Email = "bruno@email.com", Endereco = new { Id = 3, Cidade = "São paulo", Pais = "Brasil" }},
};

string? titulo;
int contado = 0;
foreach (var aluno02 in aluno2)
{
    if (contado == 0)
        titulo = " Lista Sala 2 ";
    else
        titulo = "";

    Console.WriteLine($"\n------------{titulo}------------ \n{aluno02.Nome}");
    Console.WriteLine($"{aluno02.Endereco.Cidade}");

    contado++;

}


Console.ReadLine();

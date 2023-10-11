/* Herança - O modificador new 
 * 
 * Se um membro de uma classe derivada tiver o mesmo nome do membro de uma classe base,
 * o compilador vai emitir o aviso
 * ('member1' hides inherited member 'member2'. Use the new keyword if hiding was intended.)
 * 
 * Este aviso indica que o membro da classe derivada oculta o membro da classe base
 * 
 * Quando um método na da classe derivada oculta um membro da classe base, este membro
 * substitui(override) o membro da classe base
 * 
 * Se você realmente deseja ocultar um membro da classe base, pode usar o modificador new para
 * o membro na subclasse.
 */

Aluno aluno = new Aluno();
aluno.Nome = "Maria";
aluno.Curso = "Quimica";
Console.WriteLine(aluno.Saudacao());

Console.ReadKey();


class Pessoa
{
    public string? Nome { get; set; }
    public string Saudacao() => $"Oi, Eu sou o(a) {Nome}";
}

class Aluno : Pessoa
{
    public string? Curso { get; set; }
    /* new oculta o método Saudacao() da classe base */
    public new string Saudacao() => $"Oi, Eu sou o(a) {Nome} do curso de : {Curso}";
}
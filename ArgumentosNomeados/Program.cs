/* Argumentos nomeados você pode, enviar os argumentos em qualquer */
Console.WriteLine("## Argumentos nomeados ##");

Email email = new Email();
email.Enviar("paulofullstack@hotmail.com", "Estudos", "Estudos avançado C#");

string variavelAssunto = "Assunto";

/* Argumentos nomeados */
email.Enviar(titulo: "Estudos", destino: "paulofullstack@hotmail.com", assunto: "Estudos avançado C#");
/* Passando um argumento padrão, onde ele tem argumentos padroes antes, sem precisar setar o valor dele, pular argumentos padrão  */
email.EnviarArgumentosPadrao("paulofullstack@hotmail.com", assunto: variavelAssunto);

Console.ReadKey();

public class Email
{
    public void Enviar(string destino, string titulo, string assunto)
    {
        Console.WriteLine($"\nPara {destino} - {titulo} \n Assunto: {assunto}");
    }

    public void EnviarArgumentosPadrao(string destino, string titulo = "titulo padrao", string assunto = "assunto padrao")
    {
        Console.WriteLine($"\nPara {destino} - {titulo} \n Assunto: {assunto}");
    }


}
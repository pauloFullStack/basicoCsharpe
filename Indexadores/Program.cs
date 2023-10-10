/* Indexadores - Definição
 * 
 * Os indexadores permitem que as instâncias de uma classe ou struct sejam indexadas como um
 * array. Eles lembram as propriedades mas seus assessores(get, set) recebem parâmetros.
 * 
 * Um indexador é um membro da classe que permite acessar uma variável de membro da classe
 * ou struct usando os recursos de um array
 * 
 * Quando você define um indexador para uma classe, essa classe se comporta como um array virtual
 * e podemos acessar a instância da classe usando o operador de acesso ao array ([]) e também usar
 * índices para acessar e atribuir valores como nos arrays.
 * 
 */


/* Indexadores - Sintaxe 
 * 
 * Para declarar um indexador em um classe ou struct, use a palavra-chave this:
 * 
 * - Declaramos um indexador como um método passando um modificador de acesso (public, private, 
 * protected ou internal) seguido de um valor de retorno(não pode ser void).
 * - O nome do indexador será a palavra reservada this;
 * - A lista de parâmetros de entrada devem ser envolvida em colchetes [];
 * - Ao final basta definir os assessores get e o set para definir a lógica de acesso retornando
 * e atribuindo um valor
 */


/* Indexadores - Utilidade 
 * 
 * A utilidade de um indexador é fornecer uma sintaxe para acessar, através do indice, 
 * itens de um objeto que represente uma coleção.
 */

using Indexadores;

Time time = new Time();

time[1] = "Palmeiras";
time[3] = "Santos";
time[5] = "São Paulo";
time[7] = "Vasco";
time[-1] = "Flamengo";
time[1000] = "Bahia";

string valor1 = time[1];
string valor2 = time[3];
string valor3 = time[5];
string valor4 = time[7];
string valor5 = time[-1];
string valor6 = time[1000];

Console.WriteLine(valor1);
Console.WriteLine(valor2);
Console.WriteLine(valor3);
Console.WriteLine(valor4);
Console.WriteLine(valor5);
Console.WriteLine(valor6);


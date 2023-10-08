/* Arrays 
 * 
 * Os arrays são um 'conjunto de elementos' de mesmo tipo e dados e de tamanho fixo.
 * 
 * Um array de uma dimensão é também conhecido como vetor, e, um array de mais de
 * uma dimensão e conhecida como uma matriz.
 * 
 */


/* Usando Arrays
 * 
 * Um array é usado para armazenar mais de um valor literal do mesmo tipo em uma 
 * variável de mesmo nome.
 * 
 * Podemos declarar um array definindo o tipo dos seus elementos abrindo e fechando
 * colchetes([]) seguido do nome da variável que identifica o array
 * Exemplos: string[] nomes; int[] numeros;
 * 
 * */


/* Acessando os elementos de um Array 
 * 
 * Os elementos do 'Array' podem ser acessados usando um índice.
 * 
 * Um índice é um número associado a cada elemento do array, começando com o valor 0
 * e terminado com o tamanho do Array menos 1.
 */


/* Declarei o array */
int[] numeros;

/* Alocando memoria */
numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

/* Formas e inicializar um array */
string[] nomes = { "Ana", "Maria", "Marta", "Paulo", "Carlos" };
//string[] nome1 = new string[] { "Maria", "Marta", "Paulo", "Carlos" };
//string[] nome2 = { "Paulo", "Carlos" };

/* Acessando os elementos do array */
Console.WriteLine($"{nomes[0]}");
Console.WriteLine($"{nomes[1]}");
Console.WriteLine($"{nomes[2]}");
Console.WriteLine($"{nomes[3]}");
Console.WriteLine($"{nomes[4]}");


int[] numeros1;
numeros1 = new int[3];
/* Atribuindo na memoria valores */
numeros1[0] = 1;
numeros1[1] = 2;
numeros1[2] = 3;

Console.ReadLine();
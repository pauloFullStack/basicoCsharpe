/* Arrays com mais de uma dimensão (multidimensionais) 
 * 
 * Os arrays podem ter mais de uma dimensão e a linguagem C# suporta arrays até 32 dimensões.
 * 
 * Um array com mais de uma dimensão é basicamente um array de array
 * 
 * Um array multidimensional pode ser 'declarado' adicionando 'vírgulas' entre 'colchetes'
 * na declaração do array
 * Ex: int[,] array2d; => array bidimensional
 * Ex: int[,,] array3d; => array tridimensional
 * Ex: int[,,,] array4d; => array quadridimensional
 * 
 */


/* Arrays com duas dimensões (bidimensional)
 * 
 * Um array bidimensional pode ser pensado como uma tabela, que tem um número x de
 * linhas e um número y de colunas
 * Ex: int[3,3] nomeArray; (array bidimensional com 3 linhas e 3 colunas com o nome nomeArray)
 * 
 */


/* Array bidimensional - Identificação do elemento no array
 * 
 * Ex: int[3,3] nomes => acessando =>  nomes[0,0] nomes[0,1] nomes[0,2] nomes[1,0] ...
 * 
 * Cada elemento no array 'nomes' é identificado assim => nomes[i, j]
 * 
 * - 'nomes' é o nome do array
 * - 'i' e 'j' são os índices que indicam a 'linha e a coluna' e identificam cada elemento do array 'nomes'
 * 
 */


/* Array bidimensional - Declaração 
 * 
 * int[,] array1 = new int[3,3]
 * 
 * Define o tipo dos elementos do arrray como sendo do tipo 'int'
 * 
 * Usa a 'vírgula única' para indicar que o array é 'bidimensional'
 * 
 * Define que o array vai ser composto de '3 linhas e 3 colunas'
 * 
 * 'array1' é um array bidimensional com '3 elementos' e cada elemento é um 'array' com 3
 * elementos
 * 
 * O total de elementos que o 'array1' pode armazenar são 9 elementos. (3*3)
 * 
 */


/* Array bidimensional - Inicialização 
 * 
 * int[,] a;
 * a = new int[2,2];
 * a = new int[2,2] {{0,1},{2,3}};
 */


int[,] a;
a = new int[2, 2];

a[0, 0] = 10;
a[0, 1] = 20;
a[1, 0] = 30;
a[1, 1] = 40;

Console.WriteLine(a[0, 0]);
Console.WriteLine(a[0, 1]);
Console.WriteLine(a[1, 0]);
Console.WriteLine(a[1, 1] + "\n");

int[,] b = new int[2, 2] { { 50, 60 }, { 70, 80 } };

Console.WriteLine(b[0, 0]);
Console.WriteLine(b[0, 1]);
Console.WriteLine(b[1, 0]);
Console.WriteLine(b[1, 1] + "\n");

/* Percorrendo um array bidimensional com for e foreach */

Console.WriteLine("## Usando for ##");

int[,] numeros = {
                    { 11, 22, 33 },
                    { 44, 55, 66 },
                    { 77, 88, 99 }
                 };

/* Usando for ( GetLength acessa as dimensões do array )*/
for (int i = 0; i < numeros.GetLength(0); i++)
{
    if (i == 0)
        Console.WriteLine();

    for (int j = 0; j < numeros.GetLength(1); j++)
    {
        Console.Write($"{numeros[i, j]}  ");
    }

    Console.WriteLine();
}


/* Usando foreach  */
Console.WriteLine("## Usando foreach ##");

foreach (int element in numeros)
{
    Console.Write($"{element} ");
}


/* Execicio */
int rows = 2;
int cols = 5;

string[,] alunos = new string[rows, cols];

for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(1); j++)
    {
        Console.WriteLine($"Informe o valor para o elemento na posição [{i}, {j}]");
        alunos[i, j] = Console.ReadLine();
    }
}


Console.WriteLine("\nConteúdo do array alunos \n");

for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(1); j++)
    {
        Console.WriteLine($"[{i}, {j}] = {alunos[i,j]}\t");
    }
}

Console.ReadKey();
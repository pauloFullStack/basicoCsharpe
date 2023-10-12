/* Relacionamento entre classe - Agregação 
 * 
 * Um relacionamento de 'agregação' é um tipo especial de composição onde objetos de uma
 * classe podem conter um ou mais objetos de outra classe
 * 
 * A agregação é um relacionamento do tipo: "Tem um"
 * Representa uma relação Todo-parte
 * - A parte e o todo são independentes
 * - A parte pode existir sem o todo
 * 
 * O tempo de vida dos objetos constituintes(partes) é diferente do tempo de suas agregações(Todo)
 * 
 * - Na agregação cada objeto possui o seu próprio ciclo de vida
 * - Um Professor pode existir sem um Departamento
 * - Excluindo o Departamento o Professor continua existindo
 * - A agregação seria um relacionamento mais fraco que a composição
 */


/* Toda agregação e composição é um tipo especial de associação 
 * 
 * Uma agregação é uma associação mais fraca
 * 
 * Uma composição é uma associação forte
 * 
 * As composições permitem representar sistemas de objetos, onde todos os componentes devem
 * estar presentes para que seja válida.
 */

using Agregacao;

Professor prof1 = new Professor("Angelica", "Química");
Professor prof2 = new Professor("Maria", "Inglês");
Professor prof3 = new Professor("Ana", "Literatura");
Professor prof4 = new Professor("Paulo", "Matemática");

Departamento dep1 = new Departamento("Exatas");
dep1.IncluirProfessor(prof1);
dep1.IncluirProfessor(prof4);
dep1.ListaProfessores();

Departamento dep2 = new Departamento("Humanas");
dep2.IncluirProfessor(prof2);
dep2.IncluirProfessor(prof3);
dep2.ListaProfessores();

Console.ReadKey();
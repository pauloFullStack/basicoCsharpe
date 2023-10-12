/* Tipos de relacionamentos entre classes 
 * 
 * 1 - Relacionamento "É um" - Representado pela 'Herança'
 * 2 - Relacionamento "Tem um" - Representado pela 'Composição' e pela 'Agregação'
 * 
 * A Composição e Agregação são técnicas de programação que permitem que uma classe "contenha" um
 * ou mais objetos de outras classes para formar um grande objeto realizando algumas funcionalidades
 * especifícas.
 * 
 * O contêiner é a superclasse ou classe pai e as classes contidas na superclasse são subclasses ou 
 * classes filhas, onde a classe pai(superclasse) e as classes filhas(subclasses) possuem um relacionamento
 * "tem-um"
 */


/* Composição 
 * 
 * Um relacionamento de 'composição' ocorre quando um objeto de uma classe é 'composto' de um ou
 * mais objetos de outras classes.
 * 
 * Este relacionamento é formado quando uma classe tem uma referência a outra classe como propriedade
 * de instância.
 * 
 * Na composição, uma classe que contém a referência a outra classe é a 'classe pai' sendo a proprietária
 * da 'classe filha', e a classe filha 'não existe' sem a classe pai.
 */


/* Composição - Relação Todo - parte 
 * 
 * A composição é um relacionamento do tipo: "Tem um"
 * 
 * Representa uma relação Todo - parte
 * - O objeto todo(pai) é responsável por criar e destruir as suas partes(filhas);
 * - A parte(filha) não existe sem o todo(pai)
 * - Um mesmo objeto-parte não pode se associar a mais de um objeto-Todo;
 * 
 * Assim como a herança, a composição permite a reutilização de código.
 */


/* Composição - Definição no código 
 * 
 * A classe Casa contém referência às classes Telhado e Alicerce expressando o relacionamento
 * de Composição entre a classe Casa e as classes Telhado e Alicerce
 * 
 * As classes Telhado e Alicerce não fazem sentido sem a classe Casa
 * 
 * Usando a composição, podemos escolher as funcionalidades que queremos implementar na classe
 * composta (Casa) com base nos seus componentes (Telhado e Alicerce)
 * Na herança a classe base teria acesso a todos os membros da classe derivada
 */
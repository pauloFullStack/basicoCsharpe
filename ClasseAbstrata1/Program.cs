// Modificador abstract
  
//   O modificador 'abstract' indica que o recurso que está sendo modificado tem uma implementação
//   ausente ou incompleta.
  
//   Quando uma classe ou membro de uma classe é declarado como abstract, isso indica que ele não 
//   possui uma implementação completa. Em vez disso, ele fornece apenas uma estrutura ou contrato 
//   para as classes derivadas (subclasses) que devem fornecer a implementação completa.
  
//   Ele pode ser usado com classes, métodos, propriedades, indexadores e eventos
  
//   Usar o modificador 'abstract' em uma declaração de 'classe' indica que a classe destina-se
//   apenas a ser uma classe base de outras classes, não podendo ser instanciada
  
//   Membros marcados com o modificador 'abstract' devem ser implementados por classes não abstratas
//   que derivam de uma classe abstrata.
  
//   Uma classe abstrata é um tipo especial de classe que não pode ser instanciada, ou seja, você não pode
//   criar um objeto a partir de uma classe abstrata(mas pode ser herdada)
  
//   Uma classe abstrata é definida usando o modificador 'abstract' e pode conter métodos comuns e métodos
//   abstratos que também são definidos pelo modificador abstract
  
//   - Um método abstrato é um método que não possui implementação na classe abstrata
//   - Um método abstrato possui somente a definição de sua assinatura
//   - Um método abstrato é implicitamente um método virtual
//   - A implementação do método abstrato é feita na classe derivada
//   - As classes derivadas de uma classe abstrata são obrigadas a implementar os seus métodos abstratos
//   - É um erro usar modificadores virtual e static em um método abstrato
//   - As propriedades abstratas se comportam como os métodos abstratos
//   - Usar o modificador abstract na declaração da classe
//   - Pode possuir métodos comuns e abstratos
//   - Não pode ser instanciada mas pode ser herdada
//   - Os métodos abstratos devem ser implementados pelas classes derivadas
 
 


using ClasseAbstrata1;

Quadrado q = new Quadrado();
Console.WriteLine(q.Descricao());

Console.WriteLine("\nInforme a cor da figura");
q.Cor = Console.ReadLine();

Console.WriteLine("\nInforme o valor do lado do quadrado");
q.Lado = Convert.ToInt32(Console.ReadLine());

q.CalcularArea();
q.CalcularPerimetro();

Console.WriteLine($"\nÁrea do quadrado : {q.Area} m2");
Console.WriteLine($"\nPerímetro do quadrado : {q.Perimetro}");

Console.WriteLine($"\nO quadrado tem a cor : {q.Cor}");

Console.ReadKey();
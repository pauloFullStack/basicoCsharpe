
using GenericsExercicio;

ClasseGenerica<int> objInt = new ClasseGenerica<int>();
objInt.Adicionar(1);
objInt.Adicionar(2);
objInt.Adicionar(3);
objInt.Adicionar(4);
objInt.Adicionar(5);


for (int i = 0; i < 5; i++)
    Console.WriteLine(objInt[i]);

ClasseGenerica<string> objStr = new ClasseGenerica<string>();
objStr.Adicionar("Paulo");
objStr.Adicionar("Renato");
objStr.Adicionar("Alves");
objStr.Adicionar("Da");
objStr.Adicionar("Silva");


for (int i = 0; i < 5; i++)
    Console.WriteLine(objStr[i]);

Console.ReadKey();


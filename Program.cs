//using EstudoOppCSharp.carro;

Aluno aluno = new Aluno("Nome", 17, "email@email.com", 1);
Pessoa professor = new Professor("NomeProfessor", 20, "professor@email.com", "TI");
Console.WriteLine(aluno.GetNome());
Console.WriteLine(professor.GetNome());

Console.WriteLine();

Esportivo car1 = new("BMW", "Série 1", "preto", false);
Carro car2 = new Popular("Renault", "Fluence", "prata", 4);
Carro car3 = new Esportivo("BMW", "Série 3", "vermelho", true);

Console.WriteLine(car1.GetCarInfos());
Console.WriteLine(car2.GetCarInfos());
Console.WriteLine(car3.GetCarInfos());
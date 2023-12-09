using ConstrutorAluno;

Aluno a1 = new Aluno();
a1.AtribuirRa();
Console.Write("Digite o nome do aluno: ");
a1.Nome = Console.ReadLine();
Console.Write("Digite a idade do aluno: ");
a1.Idade = Convert.ToInt32(Console.ReadLine());

Aluno a2 = new Aluno();
a2.AtribuirRa();
Console.Write("Digite o nome do aluno: ");
a2.Nome = Console.ReadLine();
Console.Write("Digite a idade do aluno: ");
a2.Idade = Convert.ToInt32(Console.ReadLine());

Aluno a3 = new Aluno();
a3.AtribuirRa();
Console.Write("Digite o nome do aluno: ");
a3.Nome = Console.ReadLine();
Console.Write("Digite a idade do aluno: ");
a3.Idade = Convert.ToInt32(Console.ReadLine());

a1.MostrarAtributos();
a2.MostrarAtributos();
a3.MostrarAtributos();
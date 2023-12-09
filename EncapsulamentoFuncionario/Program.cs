using EncapsulamentoFuncionario;

Funcionario f1 = new Funcionario();

Console.Write("Digite a matrícula: ");
f1.Matricula = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o nome: ");
f1.Nome = Console.ReadLine();
Console.Write("Digite o salário: ");
f1.Salario = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a porcentagem de aumento: ");
double porcentagem = Convert.ToDouble(Console.ReadLine());
f1.NovaPorcentagem(porcentagem);
f1.MostrarAtributos();

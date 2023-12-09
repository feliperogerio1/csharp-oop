using System.Runtime.Serialization.Json;
using FuncionarioAbstrato;

Assalariado a1 = new Assalariado(1, "Ana", 1000);
Assalariado a2 = new Assalariado(2, "Bel", 2000);

Comissionado c1 = new Comissionado(3, "Lia", 1100, 20);
Comissionado c2 = new Comissionado(4, "Teo", 2100, 30);

Departamento d1 = new Departamento(1, "Suporte");
d1.Admitir(a1);
d1.Admitir(c1);
d1.ListarFuncionario();
//d1.Demitir(3);
//d1.ListarFuncionario();
Console.WriteLine("Total R$" + d1.CalcularFolha(30));

Departamento d2 = new Departamento(2, "Desenvolvimento");
d2.Admitir(a2);
d2.Admitir(c2);
d2.ListarFuncionario();
Console.WriteLine("Total R$" + d2.CalcularFolha(30));

//realizando a instância dos dependentes
Dependente dependente1 = new Dependente(1, "Jose", 15);
Dependente dependente2 = new Dependente(2, "Luis", 17);
Dependente dependente3 = new Dependente(3, "João", 19);
Dependente dependente4 = new Dependente(4, "Henri", 14);

//adicionando os dependentes aos funcionários
a1.AdicionarDependente(dependente1);
a1.AdicionarDependente(dependente2);
c1.AdicionarDependente(dependente3);
a2.AdicionarDependente(dependente4);

//calcular o total de dependentes
Console.WriteLine("Total de dependentes de " +  a1.Nome  + ": " + a1.CalcularTotalDependente());
Console.WriteLine("Total de dependentes de " + c1.Nome + ": " + c1.CalcularTotalDependente());
Console.WriteLine("Total de dependentes de " + a2.Nome + ": " + a2.CalcularTotalDependente());

//listar os dependentes
a1.ListarDependente();
c1.ListarDependente();
a2.ListarDependente();
c2.ListarDependente();

//removendo os dependentes
a1.RemoverDependentesMaioridade(2);
c1.RemoverDependentesMaioridade(3);

//calular o total de dependentes por meio da classe Departamento
d1.MostrarQtdeDependentesFuncionario();
d2.MostrarQtdeDependentesFuncionario();
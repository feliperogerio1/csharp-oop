using ClasseFuncionario;

Funcionario objeto1 = new Funcionario();
// tipo ou classe / objeto / alocação de memória / construtor da classe

System.Console.WriteLine("Digite o código:");
objeto1.codigo = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Digite o nome:");
objeto1.nome = Console.ReadLine();
System.Console.WriteLine("Digite o salário:");
objeto1.salario = Convert.ToDouble(Console.ReadLine());
objeto1.MostrarAtributos();
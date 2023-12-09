using ClasseProduto;

Produto objeto1 = new Produto();
System.Console.Write("Digite o código: ");
objeto1.codigo = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Digite a descrição: ");
objeto1.descricao = Console.ReadLine();
System.Console.WriteLine("Digite o preço: ");
objeto1.preco = Convert.ToDouble(Console.ReadLine());
objeto1.MostrarAtributos();

Produto objeto2 = new Produto();
System.Console.Write("Digite o código: ");
objeto2.codigo = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Digite a descrição: ");
objeto2.descricao = Console.ReadLine();
System.Console.WriteLine("Digite o preço: ");
objeto2.preco = Convert.ToDouble(Console.ReadLine());
objeto2.MostrarAtributos();

Console.WriteLine($"Total {objeto1.preco + objeto2.preco:c}");
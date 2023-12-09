using TrabalhoHerancaComposicaoVenda;

VenderCaixa controlador = new VenderCaixa();
ProdutoDAO dao = controlador.IniciarProdutoDAO();

Console.WriteLine("\n=============================");
Console.WriteLine("Bem vindo ao supermercado C#!");
Console.WriteLine("=============================\n");

Console.WriteLine("====================");
Console.WriteLine("Inserção de produtos");
Console.WriteLine("====================");
Console.WriteLine("Quantos produtos deseja inserir?");
int cont = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < cont; i++ ) {
    Produto p = new Produto();
    p.CadastrarProduto();
    dao.AdicionarProduto(p);
}

Venda venda = controlador.IniciarVenda();
Console.WriteLine("\nVenda iniciada!\n");

Console.WriteLine("==========================");
Console.WriteLine("Inserção de itens de venda");
Console.WriteLine("==========================");
Console.WriteLine("Quantos produtos deseja inserir em sua venda? ");
int cont2 = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < cont2; i++ ) {
    Console.Write("Digite o código do produto a ser comprado: ");
    int cod = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite a quantidade a ser comprada: ");
    int qtde = Convert.ToInt32(Console.ReadLine());
    controlador.LancarItem(cod, qtde);   
}

controlador.FinalizarVenda();

Console.WriteLine("\n===================");
Console.WriteLine("Realizar pagamento");
Console.WriteLine("===================");
Console.WriteLine("Quantos métodos de pagamento irá utilizar? ");
int cont3 = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < cont3; i++ ) {
    Console.WriteLine("Qual será a opção de pagamento?");
    Console.WriteLine("1 - Cartão");
    Console.WriteLine("2 - Cheque");
    Console.WriteLine("3 - Espécie");
    string tipo = Console.ReadLine();
    controlador.Pagar(tipo);
}

dao.ExibirDados();
Console.WriteLine();
venda.ExibirDadosVetItens();
Console.WriteLine();
venda.ExibirDadosVenda();
Console.WriteLine();
venda.ExibirDadosVetPagamento();




           
           
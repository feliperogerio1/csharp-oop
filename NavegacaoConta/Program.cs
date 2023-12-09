using NavegacaoConta;

Cliente cli1 = new Cliente("Felipe", 222);
Cliente cli2 = new Cliente("Rogerio", 333);

Conta conta1 = new Conta();
conta1.VetorTitular = new List<Cliente>();
conta1.AdicionarClientes(cli1);
conta1.AdicionarClientes(cli2);

foreach (Cliente c in conta1.VetorTitular)
{
    Console.WriteLine("Nome: " + c.Nome);
}
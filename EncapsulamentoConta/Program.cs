// função Main()
using EncapsulamentoConta;

Conta c1 = new Conta();
c1.Numero = 0;
c1.Titular = "Ana";
c1.Saldo = 100;
Console.Write("Digite o número da conta: ");
int novoNumeroConta = Convert.ToInt32(Console.ReadLine());
//c1.SetNumero(novoNumeroConta);
c1.Numero = novoNumeroConta;//set
//Console.Write("Número da conta: " + c1.GetNumero());
Console.Write("Número da conta: " + c1.Numero);


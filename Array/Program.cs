using Array;

// Declaração do vetor do tipo Conta
Conta[] vetConta = new Conta[3];

for (int i = 0; i <vetConta.Length; i++)
{
    // instanciar cada posição do vetor
    vetConta[i] = new Conta();
    Console.WriteLine("Cadastre o número da conta:");
    vetConta[i].numero = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Cadastre o titular da conta:");
    vetConta[i].titular = Console.ReadLine();
    Console.WriteLine("Cadastre o saldo da conta:");
    vetConta[i].saldo = Convert.ToDouble(Console.ReadLine());
}
//apresentar o vetor das contas
for (int i = 0; i <vetConta.Length; i++)
    vetConta[i].MostrarAtributo();

foreach (Conta c in vetConta)
    c.MostrarAtributo();
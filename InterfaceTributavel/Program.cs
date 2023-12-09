using InterfaceTributavel;

ContaCorrente conta = new ContaCorrente();
conta.Saldo = 100;

SeguroDeVida seguro = new SeguroDeVida();

TotalizadorDeTributos totalizador = new TotalizadorDeTributos();
totalizador.Adiciona(conta);
totalizador.Adiciona(seguro);

Console.WriteLine(totalizador.Total);
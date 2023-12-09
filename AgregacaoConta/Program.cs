using AgregacaoConta;

Cliente cli = new Cliente("Maira", 555);

Conta conta1 = new Conta();
conta1.Numero = 10;
conta1.Titular = cli;
conta1.Saldo = 100;

Conta conta2 = new Conta();
conta2.Numero = 12;
conta2.Titular = new Cliente("Felipe", 999);
conta2.Saldo = 100000000;
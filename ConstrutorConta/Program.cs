using ConstrutorConta;

Conta c1 = new Conta();
c1.MostrarAtributos();

Conta c2 = new Conta(2);
c2.MostrarAtributos();

Conta c3 = new Conta(3, 500000);
c3.MostrarAtributos();

Conta c4 = new Conta(4, "joão", 140000000000);
c4.MostrarAtributos();

Console.WriteLine("Quantidade de instâncias: " + Conta.QtdeInstancias);
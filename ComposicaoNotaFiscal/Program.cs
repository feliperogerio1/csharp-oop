using ComposicaoNotaFiscal;

NotaFiscal nf = new NotaFiscal(1, "09/09");
nf.AdicionarItens(34);
nf.AdicionarItens(20);

foreach(ItemNotaFiscal item in nf.VetorItens)
    Console.WriteLine(item.Quantidade);
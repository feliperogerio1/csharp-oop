using HerancaFuncionario;
internal class Program
{
    private static void Main(string[] args)
    {
        Funcionario f = new Funcionario(1, "Ana", 1000);
        Console.WriteLine("Funcionário - Bonificação R$" + f.CalcularBonificacao());
        Secretario s = new Secretario(2, "Bia", 1000);
        Console.WriteLine("Secretário - Bonificação R$" + s.CalcularBonificacao());
        Gerente g = new Gerente(3, "Lia", 1000);
        Console.WriteLine("Gerente - Bonificação R$" + g.CalcularBonificacao());
        Diretor d = new Diretor(4, "Louis", 1000);
        Console.WriteLine("Diretor - Bonificação R$" + d.CalcularBonificacao());
        GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
        gerenciador.TotalizadorBonificacao(f);
        gerenciador.TotalizadorBonificacao(s);
        gerenciador.TotalizadorBonificacao(g);
        gerenciador.TotalizadorBonificacao(d);
        gerenciador.Exibir();
    }
}
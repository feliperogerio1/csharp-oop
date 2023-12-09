//método main
using ExcecaoArquivo;
using System.IO;
/*
try
{
    // Isto causará uma exceção
    File.OpenRead("ArquivoLeitura.txt");
}
catch (FileNotFoundException e)
{
    Console.WriteLine();
    Console.WriteLine("Erro pelo FileNotFoundException");
    Console.WriteLine("-------------------------------------");
    Console.WriteLine(e.ToString());
    Console.WriteLine();
}
catch (DirectoryNotFoundException e)
{
    Console.WriteLine();
    Console.WriteLine("Erro pelo DirectoryNotFoundException");
    Console.WriteLine("-------------------------------------");
    Console.WriteLine(e.ToString());
    Console.WriteLine();
}
catch (Exception e)
{
    Console.WriteLine();
    Console.WriteLine("Erro pelo Exception");
    Console.WriteLine("-------------------------------------");
    Console.WriteLine(e.ToString());
    Console.WriteLine();
}
Console.WriteLine("Programa encerrado.");
*/
/*
int valor1 = 100, valor2 = 0, total = 0;
try //Bloco onde poderá ocorrer algum erro
{
    total = valor1 / valor2;
}
catch (Exception ex) //Classe responsável pelo tipo de erro
{
    Console.WriteLine("Erro: " + ex.Message);
}
finally //Bloco que sempre será executado, ocorrendo ou não erros no bloco try
{
    Console.WriteLine("Mesmo não ocorrendo uma exceção acima esta mensagem será exibida!");
    //encerrar arquivos ou conexões
}
*/
Conta c = new Conta();
try 
{
    c.Depositar(-100);
}
catch 
{
    Console.WriteLine("Arguemento inválido");
}

Console.WriteLine("Saldo atual: " + c.Saldo);
// Main() implicita
/*
System.Console.WriteLine("Digite o endereço: ");
string enderecooo = Console.ReadLine();
System.Console.WriteLine("Digite a idade: ");
int idade = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Digite a nota da prova: ");
double p1 = Convert.ToDouble(Console.ReadLine());
if (p1 >= 6) 
{
    System.Console.WriteLine("Aprovado!");
}
else if (p1 == 0) 
{
    System.Console.WriteLine("Não fará exame.");
}
else 
{
    System.Console.WriteLine("Reprovado ): ");
}
char estacao = 'P';
switch (estacao)
{
    case 'I': System.Console.WriteLine("Inverno"); // estação == 1
        break;
    case 'P': System.Console.WriteLine("Primavera");
        break;
    default: // else
        System.Console.WriteLine("Estação errada");
        break;
}
// fazer a tabuada do 5
for (int tabuada = 1; tabuada <= 10; tabuada++) {
    System.Console.WriteLine("5 x " + tabuada + " = " + 5 * tabuada);
}
for (int tabuada = 10; tabuada >= 1; tabuada--) {
    System.Console.WriteLine("5 x " + tabuada + " = " + 5 * tabuada);
}

int tabuada = 1;
while (tabuada <= 10) {
    System.Console.WriteLine("5 x " + tabuada + " = " + 5 * tabuada);
    tabuada++;
}

//fazer a tabuada do 3 ao 7
for (int cont = 3; cont <= 7; cont++) {
    System.Console.WriteLine();
    for (int tabuada = 1; tabuada <= 10; tabuada++) {
        System.Console.WriteLine(cont + " x " + tabuada + " = " + cont * tabuada);
    }
}
*/

int[] vetIdade = new int[5];
int cont = 0;
for (int i = 0; i < 5; i++) {
    Console.Write("Cadastre a idade: ");
    vetIdade[i] = Convert.ToInt32(Console.ReadLine());
}
double somaIdades = 0, media;
//contar quantas pessoas são maiores de 18 anos
for (int i = 0; i < 5; i++) 
{
    Console.Write(vetIdade[i] + "\t");
    somaIdades = somaIdades + vetIdade[i];
    if (vetIdade[i] > 18) {
        cont = cont + 1;
    }
}

media = somaIdades / vetIdade.Length;
System.Console.WriteLine($"Média de idades: {media:n}. Foram encontradas {cont} pessoas com mais de 18 anos.");
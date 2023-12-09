//função - método Main() - implicito
using System.ComponentModel;
using System.Runtime.Intrinsics.Arm;
using _22._08;

//Para realizar a instanciação tem dois passos:
//1 - declarar a variavel do tipo classe 
NewClass objeto1;


//2 - instanciar a variavel 
objeto1 = new NewClass();
//manipular os dados do objeto
objeto1.numero = 1;
objeto1.titular = "Ana";
objeto1.saldo = 100;
objeto1.MostrarAtributo();
objeto1.Sacar(10);
objeto1.MostrarAtributo();


NewClass objeto2 = new NewClass();
objeto2.numero = 2;
objeto2.titular = "Lis";
objeto2.saldo = 200;
objeto2.MostrarAtributo();
objeto2.Depositar(20);
objeto2.MostrarAtributo();

objeto1.Transferir(50, objeto2);
objeto1.MostrarAtributo();
objeto2.MostrarAtributo();



/*
NewClass objeto3 = new NewClass();
System.Console.WriteLine("Digite o número da conta:");
objeto3.numero = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Digite o titular da conta:");
objeto3.titular = Console.ReadLine();
System.Console.WriteLine("Digite o saldo da conta:");
objeto3.saldo = Convert.ToDouble(Console.ReadLine());
//mostrar os dados cadastrados
objeto3.MostrarAtributo();
*/
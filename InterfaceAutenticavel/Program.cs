using InterfaceAutenticavel;

Cliente c = new Cliente();
c.Senha = 123;

Gerente g = new Gerente();
g.Senha = 200;

Diretor d = new Diretor();
d.Senha = 300;

IAutenticavel ia = c;
ia.Autenticar(123);

ia = g;
Console.WriteLine(ia.Autenticar(201));

IAutenticavel ia1 = d;
Console.WriteLine(ia1.Autenticar(300));
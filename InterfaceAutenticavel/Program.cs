// Método Main()
using InterfaceAutenticavel;

Cliente c = new Cliente();
c.Senha = 100;

IAutenticavel it = c;
it.Autenticar(100);
Console.WriteLine("Autenticou: " + it.Autenticar(100));

Diretor d = new Diretor();
d.Senha = 200;
IAutenticavel itd = d;
Console.WriteLine("Autenticou: " + itd.Autenticar(200));

Gerente g = new Gerente();
g.Senha = 150;
IAutenticavel itg = g;
Console.WriteLine("Autenticou: " + itg.Autenticar(150));
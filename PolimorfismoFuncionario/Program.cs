//Método Main()
using PolimorfismoFuncionario;

Funcionario f = new Funcionario(1, "João", 1000);
Console.WriteLine("Bonificação do funcionário: " + f.CalcularBonificacao());

Secretario s = new Secretario(2, "Bel", 1000);
Console.WriteLine("Bonificação do secretário: " + s.CalcularBonificacao());

Gerente g = new Gerente(3, "Ana", 1000);
Console.WriteLine("Bonificação do gerente: " + g.CalcularBonificacao());

Diretor d = new Diretor(4, "Paulo", 1000);
Console.WriteLine("Bonificação do diretor: " + d.CalcularBonificacao());

GerenciadorBonificacao gb = new GerenciadorBonificacao();
gb.totalizadorBonificacao(f);
gb.totalizadorBonificacao(s);
gb.totalizadorBonificacao(g);
gb.totalizadorBonificacao(d);
Console.WriteLine("O valor total da bonificação é de " + gb.totalBonificacao);
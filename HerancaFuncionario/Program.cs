using HerancaFuncionario;

Funcionario f = new Funcionario();
f.Codigo = 1;
f.Nome = "João";
f.Salario = 1000;
f.Mostrar();

Horista h = new Horista();
h.Codigo = 2;
h.Nome = "Maria";
h.Salario = 1000;
h.QtdeHorasSemana = 40;
h.Mostrar();

Mensalista m = new Mensalista();
m.Codigo = 3;
m.Nome = "José";
m.Salario = 1000;
m.QtdeHorasTrabalhadas = 176;
m.Mostrar();

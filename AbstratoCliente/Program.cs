using AbstratoCliente;

//Cliente c = new Cliente();
ClienteFisico cf = new ClienteFisico(1, "João", "Rua 1", 25, 123456);
cf.Mostrar();

ClienteJuridico cj = new ClienteJuridico(2, "Empresa 1", "Rua 2", 42, 123456789);
cj.Mostrar();

Teste t = new Teste();
t.verificaIdade(cf);
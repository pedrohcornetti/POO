using AbstratoCliente;

//Cliente c = new Cliente();
ClienteFisico cf = new ClienteFisico(1, "João", "Rua 1", 1111);
cf.Mostrar();

ClienteJuridico cj = new ClienteJuridico(2, "Empresa 1", "Rua 2", 2222);
cj.Mostrar();
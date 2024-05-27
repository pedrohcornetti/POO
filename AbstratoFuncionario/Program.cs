// Método Main()
using AbstratoFuncionario;
using System;
using System.Collections.Generic;

        // Criando funcionários
        Assalariado a1 = new Assalariado(1, "Ana", 1000);
        Assalariado a2 = new Assalariado(2, "Bia", 1000);
        Comissionado c1 = new Comissionado(3, "Teo", 1000, 20);
        Comissionado c2 = new Comissionado(4, "Tais", 1000, 30);

        // Criando dependentes
        Dependente d1 = new Dependente(1, "Carlos", 12);
        Dependente d2 = new Dependente(2, "Ana", 10);
        Dependente d3 = new Dependente(3, "Pedro", 15);

        // Adicionando dependentes aos funcionários
        a1.AdicionarDependente(d1);
        a1.AdicionarDependente(d2);
        c1.AdicionarDependente(d3);

        // Adicionando funcionários a um departamento
        Departamento depto1 = new Departamento(10, "TI");
        depto1.Admitir(a1);
        depto1.Admitir(c1);

        Departamento depto2 = new Departamento(11, "RH");
        depto2.Admitir(a2);
        depto2.Admitir(c2);

        // Listar dependentes
        Console.WriteLine("Dependentes de Ana:");
        a1.ListarDependentes();
        
        Console.WriteLine("Dependentes de Teo:");
        c1.ListarDependentes();

        // Calcular e mostrar a quantidade de dependentes de cada funcionário
        Console.WriteLine($"Total de dependentes de Ana: {a1.CalcularTotalDependentes()}");
        Console.WriteLine($"Total de dependentes de Teo: {c1.CalcularTotalDependentes()}");

        // Calcular a quantidade de dependentes de cada departamento
        Console.WriteLine($"Total de dependentes no departamento TI: {depto1.CalcularTotalDependentes()}");
        Console.WriteLine($"Total de dependentes no departamento RH: {depto2.CalcularTotalDependentes()}");

        // Listar funcionários e calcular folha de pagamento
        depto1.ListarFuncionarios();
        Console.WriteLine($"Custo da folha de pagamento do departamento TI: {depto1.CalcularFolha(30):C}");
        
        depto2.ListarFuncionarios();
        Console.WriteLine($"Custo da folha de pagamento do departamento RH: {depto2.CalcularFolha(30):C}");
using System;
using System.Collections.Generic;

public class Program
{
    static List<Produto> produtos = new List<Produto>();
    static List<Venda> vendas = new List<Venda>();

    public static void Main()
    {
        int opcao = 0;
        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Cadastrar Produto");
            Console.WriteLine("2. Registrar Venda");
            Console.WriteLine("3. Realizar Pagamento");
            Console.WriteLine("4. Sair");
            Console.Write("Selecione uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                CadastrarProduto();
            }
            else if (opcao == 2)
            {
                RegistrarVenda();
            }
            else if (opcao == 3)
            {
                RealizarPagamento();
            }
            else if (opcao == 4)
            {
                Console.WriteLine("Saindo...");
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }
        } while (opcao != 4);
    }

    static void CadastrarProduto()
    {
        Console.Write("Código: ");
        long codigo = long.Parse(Console.ReadLine());
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine());
        Console.Write("Estoque: ");
        int estoque = int.Parse(Console.ReadLine());

        Produto produto = new Produto(codigo, nome, preco, estoque);
        produtos.Add(produto);

        Console.WriteLine("Produto cadastrado com sucesso!");
    }

    static void RegistrarVenda()
    {
        Console.WriteLine("Registrando venda...");
        Venda venda = new Venda(DateTime.Now);

        char continuar;
        do
        {
            Console.Write("Código do produto: ");
            long codigo = long.Parse(Console.ReadLine());
            Produto produto = produtos.Find(p => p.Codigo == codigo);

            if (produto != null)
            {
                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                if (quantidade <= produto.Estoque)
                {
                    produto.Estoque -= quantidade;
                    ItemVenda itemVenda = new ItemVenda(quantidade, produto.Preco);
                    venda.AdicionarItem(itemVenda);
                }
                else
                {
                    Console.WriteLine("Quantidade insuficiente em estoque!");
                }
            }
            else
            {
                Console.WriteLine("Produto não encontrado!");
            }

            Console.Write("Deseja adicionar outro item? (s/n): ");
            continuar = char.Parse(Console.ReadLine());
        } while (continuar == 's');

        vendas.Add(venda);
        Console.WriteLine("Venda registrada com sucesso!");
    }

    static void RealizarPagamento()
    {
        Console.WriteLine("Realizando pagamento...");
        Console.Write("Código da venda: ");
        int codigoVenda = int.Parse(Console.ReadLine());
        Venda venda = vendas[codigoVenda];

        Console.WriteLine("Total da venda: " + venda.Total);
        Console.WriteLine("Formas de pagamento:");
        Console.WriteLine("1. Espécie");
        Console.WriteLine("2. Cheque");
        Console.WriteLine("3. Cartão");
        Console.Write("Selecione a forma de pagamento: ");
        int formaPagamento = int.Parse(Console.ReadLine());

        if (formaPagamento == 1)
        {
            Console.Write("Quantia: ");
            double quantia = double.Parse(Console.ReadLine());
            if (quantia < venda.Total)
            {
                Console.WriteLine("Quantia insuficiente!");
                return;
            }
            Especie especie = new Especie(quantia, venda.Total);
            Console.WriteLine("Troco: " + especie.Troco());
        }
        else if (formaPagamento == 2)
        {
            Console.Write("Número do cheque: ");
            long numero = long.Parse(Console.ReadLine());
            Console.Write("Data de depósito: ");
            DateTime dataDeposito = DateTime.Parse(Console.ReadLine());
            Console.Write("Situação (0 - Pendente, 1 - Compensado, 2 - Devolvido): ");
            int situacao = int.Parse(Console.ReadLine());
            Cheque cheque = new Cheque(numero, dataDeposito, situacao, venda.Total);
        }
        else if (formaPagamento == 3)
        {
            Console.Write("Dados da transação: ");
            string dadosTransacao = Console.ReadLine();
            Console.Write("Resultado da transação (0 - Falha, 1 - Sucesso): ");
            int resultadoTransacao = int.Parse(Console.ReadLine());
            Cartao cartao = new Cartao(dadosTransacao, resultadoTransacao, venda.Total);
        }
        else
        {
            Console.WriteLine("Forma de pagamento inválida!");
        }

        Console.WriteLine("Pagamento realizado com sucesso!");
    }
}

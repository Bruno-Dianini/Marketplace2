using System;
using System.Collections.Generic;

namespace AppEmpresa
{
    class AppEmpresa
    {
        static void Main(string[] args)
        {
            // Simulando uma lista de clientes
            List<Cliente> listaClientes = new List<Cliente>();

            // Adicionando um cliente à lista
            Cliente cliente = new Cliente();
            cliente.Nome = "Rafael Teste";
            cliente.Endereco = "Rua Exemplo, 123";
            cliente.Telefone = "123-456-7890";
            cliente.Rg = "1234567";
            cliente.Email = "rafael@teste.com";
            cliente.Cpf = "123.456.789-01";
            listaClientes.Add(cliente);

            // Simulando uma lista de vendedores
            List<Vendedor> listaVendedores = new List<Vendedor>();

            // Adicionando um vendedor à lista
            Vendedor vendedor = new Vendedor();
            vendedor.Nome = "João Vendedor";
            vendedor.Endereco = "Avenida Venda, 456";
            vendedor.Rg = "9876543";
            vendedor.Email = "joao@vendedor.com";
            vendedor.Cpf = "987.654.321-09";
            vendedor.ContaBancaria = "12345-6";
            vendedor.AgenciaBancaria = "7890";
            vendedor.ContaCorrente = "78901234-5";
            listaVendedores.Add(vendedor);

            // Imprimindo informações dos clientes
            Console.WriteLine("Informações dos Clientes:");
            foreach (Cliente c in listaClientes)
            {
                Console.WriteLine("Nome: " + c.Nome);
                Console.WriteLine("Endereço: " + c.Endereco);
                Console.WriteLine("Telefone: " + c.Telefone);
                Console.WriteLine("RG: " + c.Rg);
                Console.WriteLine("Email: " + c.Email);
                Console.WriteLine("CPF: " + c.Cpf);
                Console.WriteLine();
            }

            // Imprimindo informações dos vendedores
            Console.WriteLine("Informações dos Vendedores:");
            foreach (Vendedor v in listaVendedores)
            {
                Console.WriteLine("Nome: " + v.Nome);
                Console.WriteLine("Endereço: " + v.Endereco);
                Console.WriteLine("RG: " + v.Rg);
                Console.WriteLine("Email: " + v.Email);
                Console.WriteLine("CPF: " + v.Cpf);
                Console.WriteLine("Conta Bancária: " + v.ContaBancaria);
                Console.WriteLine("Agência Bancária: " + v.AgenciaBancaria);
                Console.WriteLine("Conta Corrente: " + v.ContaCorrente);
                Console.WriteLine();
            }
        }
    }
}

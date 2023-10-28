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
            cliente.Nome = "Rafael";
            cliente.Endereco = "Rua Exemplo, 123";
            cliente.Telefone = "123-456-7890";
            cliente.Rg = "1234567";
            cliente.Email = "rafael@teste.com";
            cliente.Cpf = "123.456.789-01";
            cliente.Senha = "*************";
            listaClientes.Add(cliente);
    
            // Simulando uma lista de Produto
            List<Produto> listaProduto = new List<Produto>();

            // Adicionando um Produto à lista
            Produto produto = new Produto();
            produto.Descricao = "Ventilador";
            produto.Preco = "R$200,00";
            produto.Imagem = "Default";
            produto.Status = "Vendido";
            produto.Vendedor = "Vingador";
            produto.Categoria = "Eletro Domestico";
            listaProduto.Add(produto);

            // Simulando uma lista de vendedores
            List<Vendedor> listaVendedores = new List<Vendedor>();

            // Adicionando um vendedor à lista
            Vendedor vendedor = new Vendedor();
            vendedor.NomeFantasia = "Mestre dos magos";
            vendedor.Endereco = "Avenida Venda, 456";
            vendedor.Cnpj = "98765433213213123";
            vendedor.Email = "Mestre@vendedor.com";
            vendedor.Comissao = "30%";
            vendedor.RazaoSocial = "Pessoal Fisica";
            vendedor.Senha = "*********";
            listaVendedores.Add(vendedor);

            // Simulando uma lista de vendedores
            List<Carrinho> listaCarrinho= new List<Carrinho>();

            // Adicionando um vendedor à lista
            Carrinho carrinho = new Carrinho();
            carrinho.DataPedido = "02/10/2023";
            carrinho.ValorTotal = "R$200,00";
            carrinho.StatusPedido = "Entregue";
            carrinho.Cliente = "Rafael";
            carrinho.Produto = "Ventilador";
            listaCarrinho.Add(carrinho);

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
                Console.WriteLine("Senha: " + c.Senha);
                Console.WriteLine();
            }

            // Imprimindo informações dos vendedores
            Console.WriteLine("Informações dos Vendedores:");
            foreach (Vendedor v in listaVendedores)
            {
                Console.WriteLine("Nome Fantasia: " + v.NomeFantasia);
                Console.WriteLine("Endereço: " + v.Endereco);
                Console.WriteLine("Cnpj: " + v.Cnpj);
                Console.WriteLine("Email: " + v.Email);
                Console.WriteLine("Comissao: " + v.Comissao);
                Console.WriteLine("Razao Socila: " + v.RazaoSocial);
                Console.WriteLine("Senha: " + v.Senha);
                Console.WriteLine();
            }

            // Imprimindo informações dos vendedores
            Console.WriteLine("Informações do Carrinho:");
            foreach (Carrinho a in listaCarrinho)
            {
                Console.WriteLine("Data Pedido: " + a.DataPedido);
                Console.WriteLine("Valor Total: " + a.ValorTotal);
                Console.WriteLine("Status Pedido: " + a.StatusPedido);
                Console.WriteLine("Cliente: " + a.Cliente);
                Console.WriteLine("Produto: " + a.Produto);
                Console.WriteLine();
            }

            // Imprimindo informações dos vendedores
            Console.WriteLine("Informações do Produto:");
            foreach (Produto p in listaProduto)
            {
                Console.WriteLine("Descricao: " + p.Descricao);
                Console.WriteLine("Preco: " + p.Preco);
                Console.WriteLine("Imagem: " + p.Imagem);
                Console.WriteLine("Status: " + p.Status);
                Console.WriteLine("Vendedor: " + p.Vendedor);
                Console.WriteLine("Categoria: " + p.Categoria);
                Console.WriteLine();
            }
        
        }
    }
}

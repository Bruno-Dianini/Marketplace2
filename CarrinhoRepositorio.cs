namespace AppEmpresa
{
    class CarrinhoRepositorio
    {
        private List<Produto> listaProdutos;

        public CarrinhoRepositorio()
        {
            // Inicializa a lista de produtos no construtor.
            listaProdutos = new List<Produto>();
        }

        public void Adicionar(Produto produto)
        {
            // Adiciona o produto à lista de produtos (simulando a adição ao banco de dados).
            listaProdutos.Add(produto);
        }

        public void Atualizar(List<Produto> produtos)
        {
            // Atualiza a lista de produtos com uma nova lista de produtos.
            listaProdutos = produtos;
        }

        public void Excluir(int produtoId)
        {
            // Remove o produto com o ID especificado da lista de produtos (simulando a exclusão).
            Produto produtoParaExcluir = listaProdutos.FirstOrDefault(p => p.Id == produtoId);
            if (produtoParaExcluir != null)
            {
                listaProdutos.Remove(produtoParaExcluir);
            }
        }

        public Produto ObterPorID(int produtoId)
        {
            // Procura um produto na lista pelo ID e retorna o produto se encontrado.
            return listaProdutos.FirstOrDefault(p => p.Id == produtoId);
        }

        public List<Produto> ObterTodos()
        {
            // Retorna a lista completa de produtos.
            return listaProdutos;
        }
    }
}

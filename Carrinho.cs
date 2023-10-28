namespace AppEmpresa
{
    public class Carrinho
    {
        private string dataPedido;
        private string valorTotal;
        private string statusPedido;
        private string cliente;
        private string produto;

        public string DataPedido
        {
            get { return dataPedido; }
            set { dataPedido = value; }
        }

        public string ValorTotal
        {
            get { return valorTotal; }
            set { valorTotal = value; }
        }

        public string StatusPedido
        {
            get { return statusPedido; }
            set { statusPedido = value; }
        }

        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public string Produto
        {
            get { return produto; }
            set { produto = value; }
        }

    }
}

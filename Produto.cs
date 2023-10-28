namespace AppEmpresa
{
    public class Produto
    {
        private string descricao;
        private string preco;
        private string imagem;
        private string status;
        private string vendedor;
        private string categoria;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public string Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public string Imagem
        {
            get { return imagem; }
            set { imagem = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string Vendedor
        {
            get { return vendedor; }
            set { vendedor = value; }
        }

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
    }
}

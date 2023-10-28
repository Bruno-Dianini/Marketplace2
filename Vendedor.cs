namespace AppEmpresa
{
    public class Vendedor
    {
        private string nomeFantasia;
        private string endereco;
        private string cnpj;
        private string email;
        private string comissao;
        private string razaoSocial;

        private string senha;

        public string NomeFantasia //
        {
            get { return nomeFantasia; }
            set { nomeFantasia = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Comissao//
        {
            get { return comissao; }
            set { comissao = value; }
        }

        public string RazaoSocial //
        {
            get { return razaoSocial; }
            set { razaoSocial = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
    }
}

namespace AppEmpresa
{
    public class Cliente
    {
        private string nome;
        private string endereco;
        private string telefone;
        private string rg;
        private string email;
        private string cpf;
        private string senha;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
    }
}

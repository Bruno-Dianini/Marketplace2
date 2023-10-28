namespace AppEmpresa
{
    public class Vendedor
    {
        private string nome;
        private string endereco;
        private string rg;
        private string email;
        private string cpf;
        private string contaBancaria;
        private string agenciaBancaria;
        private string contaCorrente;

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

        public string ContaBancaria
        {
            get { return contaBancaria; }
            set { contaBancaria = value; }
        }

        public string AgenciaBancaria
        {
            get { return agenciaBancaria; }
            set { agenciaBancaria = value; }
        }

        public string ContaCorrente
        {
            get { return contaCorrente; }
            set { contaCorrente = value; }
        }
    }
}

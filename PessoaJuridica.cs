namespace CadastroPessoa
{
    public class PessoaJuridica : Pessoa
    {
        public PessoaJuridica(int id_PJ, string cnpj, string razaoSocial)
        {
            this.id_PJ = id_PJ;
            this.cnpj = cnpj;
            this.razaoSocial = razaoSocial;

        }
        public int id_PJ { get; set; }

        public string cnpj { get; set; }

        private string razaoSocial { get; set; }

        public override void pagarImposto(float salario){


        }


    }
}
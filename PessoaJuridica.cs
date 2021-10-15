namespace CadastroPessoa
{
    public class PessoaJuridica : Pessoa
    {
        public int id_PJ { get; set; }
        
        public string cnpj { get; set; }

        private string razaoSocial { get; set; }
    }
}
namespace CadastroPessoa
{
    public class PessoaFisica : Pessoa
    {
        public int id_PF { get; set; }
        
        public string cpf { get; set; }

        private datetime datadeNasc { get; set; }
    }
}
using System;

namespace CadastroPessoa
{
    public class PessoaFisica : Pessoa
    {
        public int id_PF { get; set; }
        
        public string cpf { get; set; }

        public DateTime datadeNasc { get; set; }

        public override void pagarImposto(float salario){

        }  

        public bool validardatadeNasc(DateTime data){

        DateTime dataAtual = DateTime.Today;

        double anos = (dataAtual - datadeNasc).TotalDays / 365;

        if (anos >= 18){

            return true;
        }
         else {
            
            return false;

        }
        
      }
    }
}
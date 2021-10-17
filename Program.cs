using System;

namespace CadastroPessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica PF = new PessoaFisica();
            PessoaFisica novaPF = new PessoaFisica();
            endereco end = new endereco();

            end.logradouro = "Rua Santa Monica" ;
            end.numero = 71;
            end.complemento = "proximo a Delegacia" ;
            end.enderecoComercial = false;

            novaPF.endereco = end;
            novaPF.cpf = "23678465257";
            novaPF.nome = "Nome Pessoa Fisica";
            novaPF.datadeNasc = new DateTime(1994, 12, 11);

            Console.WriteLine(novaPF.nome);
            Console.WriteLine(novaPF.datadeNasc);
            Console.WriteLine(novaPF.cpf);
            Console.WriteLine(novaPF.endereco.logradouro);
            Console.WriteLine(novaPF.endereco.numero);
            Console.WriteLine(novaPF.endereco.complemento);
            

            bool idadeValida = PF.validardatadeNasc(novaPF.datadeNasc);
            
            if (idadeValida == true)
            {
                Console.WriteLine($"Cadastro Aprovado! ");
            }
            
            else
            {
                Console.WriteLine($"Cadastro Reprovado! ");
            }
        }
    }
}

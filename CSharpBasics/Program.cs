using System;
using Cadastro;
using Modulo10;
using Modulo11;

namespace Application
{
    public class Program
    {
        static void Main(string[] args)
        {
           //AulaClasse();
           //AulaClasseLeitura();
           //AulaHeranca();
           //AulaClasseSelada();
           //AulaClasseAbstrata();
           //AulaRecord();
           //AulaInterface();
           //Conversores();
           //TrabString();
           //TrabDate();
           //TrabExcecao();
           //TrabArquivo();
           TrabLinq();
        }

        private static void AulaClasse()
        {
            var resultado = Cadastro.Calculos.SomarNumeros(4, 5);
            Console.WriteLine(resultado);

            var produto = new Cadastro.Produto();
            produto.SetId(1);
            produto.descricao = "Teclado";

            produto.ImprimirDescricao();
            //Console.WriteLine(produto.GetId());
        }

        private static void AulaClasseLeitura()
        {
           var produto = new Cadastro.Produto();
           produto.descricao = "Mouse";

          Console.WriteLine(produto.Estoque);
        }

        private static void AulaHeranca()
        {
           /*var pessoaFisica = new Cadastro.PessoaFisica();
           pessoaFisica.Id = 1;
           pessoaFisica.Endereco = "Rua tal";
           pessoaFisica.Cidade = "Aquela cidade";
           pessoaFisica.CEP = "1234567";
           pessoaFisica.CPF = "98765432123";
           
           
           pessoaFisica.ImprimirDados();
           pessoaFisica.ImprimirCPF();*/

           var funcionario = new Cadastro.Funcionario();
           funcionario.Id = 3;
           funcionario.Endereco = "Rua tal";
           funcionario.Cidade = "Aquela cidade";
           funcionario.CEP = "1234567";
           funcionario.CPF = "98765432123";
           
           funcionario.ImprimirDados();
           funcionario.ImprimirCPF();
        }

        private static void AulaClasseSelada()
        {
            /*var config = new Cadastro.Configuracao();
            config.Host = "localhost";*/

            // Outra forma de fazer
            var config = new Cadastro.Configuracao
            {
                Host = "localhost"
            };

            Console.WriteLine(config.Host);
        }

        private static void AulaClasseAbstrata()
        {
            var cachorro = new Cadastro.Cachorro();
            cachorro.Nome = "Zeke";
            cachorro.ImprimirDados();

        }
    
        private static void AulaRecord()
        {
            /*var curso1 = new Cadastro.Curso
            {
                Id = 1,
                descricao = "Curso"
            };

            var curso2 = new Curso
            {
                Id = 1,
                descricao = "Curso"
            };*/

            var curso1 = new Cadastro.Curso(1, "Curso");
            var curso2 = new Cadastro.Curso(1, "Curso");
            
            Console.WriteLine(curso1 == curso2);
            //Console.WriteLine(curso1.Equals(curso2));
        }

        private static void AulaInterface()
        {
            var notificacaoCliente = new Cadastro.NotificacaoCliente();
            notificacaoCliente.Notificar();
        }

        private static void Conversores()
        {
            var conversores = new Conversores.Conversor();
            //conversores.ConvertAndParse();
            conversores.TryParse();

        }

        private static void TrabString()
        {
            var TrabString = new Modulo10.TrabString();
            //TrabString.ConvertMin();
            //TrabString.ConvertMaius();
            //TrabString.AulaSubstring();
            //TrabString.AulaRange();
            //TrabString.AulaContains();
            //TrabString.AulaTrim();
            //TrabString.AulaStartWith();
            //TrabString.AulaReplace();
            TrabString.AulaRLength();
        }

        private static void TrabDate()
        {
            var data = new Modulo11.TrabData();
            //data.AulaDateTime();
            //data.AulaSubDatas();
            //data.AulaAddDatas();
            //data.AulaAddHoras();
            //data.AulaRecData();
            //data.AulaDateOnly();
            data.AulaTimeOnly();
        }

        private static void TrabExcecao()
        {
            var excecao = new Modulo12.TrabExcecao();
            //excecao.GerandoExcecao();
            excecao.TratandoExcecao();
        }

        private static void TrabArquivo()
        {
            var arquivo = new Modulo13.TrabArquivos();
            arquivo.AulaCriandoArquivo();
            //arquivo.AulaLendoArquivo();
            //arquivo.AulaExcluindoArquivo();
        }

        private static void TrabLinq()
        {
            var linq = new Modulo14.TrabLinq();
            //linq.AulaWhere();
            //linq.AulaOrder();
            //linq.AulaTake();
            //linq.AulaCount();
            linq.AulaFirst();
        }
    }
}
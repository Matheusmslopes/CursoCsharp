
namespace Cadastro
{
    public static class Calculos
    {
        public static int SomarNumeros(int a, int b)
        {
            return a + b;
        }
    }
    public class Produto
    {

        private int Id;
        public string descricao {get; set;}

        public int Estoque {get;}

        public Produto()
        {
            Estoque = 1;
        }

        public void ImprimirDescricao()
        {
            Console.WriteLine(GetId() + " - " + descricao);
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public int GetId()
        {
            return Id;
        }
    }

    public class Pessoa
    {
        public int Id {get; set;}

        public string Endereco {get; set;}

        public string Cidade {get; set;}

        public string  CEP {get; set;}

        public void ImprimirDados()
        {
            Console.WriteLine("Codigo: " + Id);
            Console.WriteLine("Endereço: " + Endereco);
            Console.WriteLine("Cidade: " + Cidade);
            Console.WriteLine("CEP: " + CEP);
        }
    }

    public class PessoaFisica : Pessoa
    {
        public string CPF {get; set;}

        public void ImprimirCPF()
        {
            Console.WriteLine("CPF: " + CPF);
        }
    }

    public class Funcionario : PessoaFisica
    {
        public string Matricula {get; set;}
    }

    public sealed class Configuracao
    {
        public string Host {get; set;}
    }

    public abstract class Animal
    {
        public string Nome {get; set;}

        public abstract string GetInfo();

        public void ImprimirDados()
        {
            Console.WriteLine("Nome Animal: " + Nome);
            Console.WriteLine("Info: " + GetInfo());
        }
    }

    public class Cachorro : Animal
    {
        public override string GetInfo()
        {
           return "Cachorro de 4 patas";
        }
    }

    public record Curso(int Id, string descricao);
    
    /*
    public class Curso
    {
        public int Id { get; set; }

        public string descricao { get; set; }
        
        public override bool Equals(object? obj)
        {
            if(obj == null)
                return false;

            if(obj is Curso curso)
            {
                return Id == curso.Id && descricao == curso.descricao;
            }

            return base.Equals(obj);
        }

        public static bool operator == (Curso a, Curso b)
        {
            return a.Equals(b);
        }

        public static bool operator != (Curso a, Curso b)
        {
            return !(a == b);
        }
    }*/

    public interface INotificacao
    {
        string descricao {get; set;}

        void Notificar();
    }

    public class NotificacaoCliente : INotificacao
    {
        public string descricao { get; set; }

        public void Notificar()
        {
            Console.WriteLine("Notificando Cliente");
        }
    }

    public class NotificacaoFuncionario : INotificacao
    {
        public string descricao { get; set; }

        public void Notificar()
        {
            Console.WriteLine("Notificando Funcionario");
        }
    }

}
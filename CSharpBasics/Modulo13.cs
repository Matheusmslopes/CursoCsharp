namespace Modulo13;

public class TrabArquivos
{
    public void AulaCriandoArquivo()
    {
        var escrever = new StreamWriter("cadastro.txt", true);
        Console.Write("Informe um nome: ");
        var nome = Console.ReadLine();
        escrever.WriteLine("ID...:" + Random.Shared.Next(1, 100));
        escrever.WriteLine("Nome.: " + nome);
        escrever.WriteLine("--------------");
        escrever.Close();
    }

    public void AulaLendoArquivo()
    {
        //var conteudo = File.ReadAllText("cadastro.txt");
        //Console.WriteLine(conteudo);

        var leitura = new StreamReader("cadastro.txt");
        while(!leitura.EndOfStream)
        {
            var linha = leitura.ReadLine();
            Console.WriteLine(linha);
        }

        leitura.Close();
    }

    public void AulaExcluindoArquivo()
    {
       if (File.Exists("cadastro.txt"))
            File.Delete("cadastro.txt");
    }
}
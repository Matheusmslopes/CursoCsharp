namespace Modulo10;

public class TrabString
{
    public void ConvertMin()
    {
        Console.Write("Digite alguma coisa: ");
        var resp = Console.ReadLine();
        Console.WriteLine(resp.ToLower());
    }

    public void ConvertMaius()
    {
        Console.Write("Digite alguma coisa: ");
        var resp = Console.ReadLine();
        Console.WriteLine(resp.ToUpper());
    }

    public void AulaSubstring()
    {
        Console.Write("Digite alguma coisa: ");
        var resp = Console.ReadLine();
        Console.WriteLine(resp.Substring(0,6));
    }

    public void AulaRange()
    {
        string nomeArquivo = "2022_12_01_backup.zip";

        string ano = nomeArquivo[..4];
        string extensao = nomeArquivo[^3..];
        string nome = nomeArquivo[11..^4];
        string nomeCompleto = nomeArquivo[..^4];
        Console.WriteLine(ano);
        Console.WriteLine(extensao);
        Console.WriteLine(nome);
        Console.WriteLine(nomeCompleto);
    }

    public void AulaContains()
    {
        string nomeArquivo = "2022_12_01_backup.zip";

        if (nomeArquivo.Contains("backup"))
            Console.WriteLine("Palavra encontrada");
        else
            Console.WriteLine("Palavra não encontrada");
    }

    public void AulaTrim()
    {
        string teste = "**Matheus Muruci**";

        Console.WriteLine("TrimTotal: " + teste.Trim('*'));
        Console.WriteLine("TrimInicio: " + teste.TrimStart('*'));
        Console.WriteLine("TrimFinal: " + teste.TrimEnd('*'));
    }

    public void AulaStartWith()
    {
        string teste = "Curso Csharp";

        Console.WriteLine("Inicio: " + teste.StartsWith("Curso"));
        Console.WriteLine("Final: " + teste.EndsWith("Csharp02"));
        Console.WriteLine("Final: " + teste.EndsWith("Csharp"));
    }

    public void AulaReplace()
    {
        string teste = "Curso Csharp";

        Console.WriteLine(teste);
        Console.WriteLine(teste.Replace("Curso", "CURSO"));
    }

    public void AulaRLength()
    {
        Console.Write("Digite Algo: ");
        string teste = Console.ReadLine();

        Console.WriteLine(teste);
        Console.WriteLine(teste.Length);
    }
}
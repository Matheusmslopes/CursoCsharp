namespace Conversores;

public class Conversor
{
    public void ConvertAndParse()
    {
        //int numero = int.Parse("1");
        //int numero = Convert.ToInt32("1");
        //int numero = int.Parse(null);
        bool verdadeiro = bool.Parse("true");
        Console.WriteLine(verdadeiro);
    }

    public void TryParse()
    {
        var numero ="12345";

        if (int.TryParse(numero, out int NumeroConvertido))
        {
            Console.WriteLine("Numero convertido");
        }

        Console.WriteLine(NumeroConvertido);
       
    }
}
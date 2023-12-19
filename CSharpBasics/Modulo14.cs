namespace Modulo14;

public class TrabLinq
{
    public void AulaWhere()
    {
        /*string nome = "Matheus Muruci";

        Func<char, bool> filtro = lambda => lambda =='u';
        
        //var resultado = nome.Where(lambda => lambda == 'u');
        //var resultado = nome.Where(filtro);

        var resultado = from lambda in nome where lambda =='u' select lambda;

        foreach( var letra in resultado)
        {
            Console.WriteLine(letra);
        }*/

        var numeros = new int[] {10, 50, 30, 4, 15};

        var resultado = numeros.Where(lambda => lambda >= 10);

        foreach(var numero in resultado)
        {
            Console.WriteLine(numero);
        }
    }

    public void AulaOrder()
    {
        var numeros = new int[] {10, 50, 30, 4, 15};

        var resultado = numeros.OrderBy(lambda => lambda);
        //var resultado = numeros.OrderByDescending(lambda => lambda);

        foreach(var numero in resultado)
        {
            Console.WriteLine(numero);
        }
       
    }

    public void AulaTake()
    {
        var numeros = new int[] {10, 50, 30, 4, 15};

        var resultado = numeros.Where(lambda => lambda > 10).Take(3).OrderBy(lambda => lambda);
        

        foreach(var numero in resultado)
        {
            Console.WriteLine(numero);
        }
       
    }

    public void AulaCount()
    {
        var numeros = new int[] {10, 50, 30, 4, 15};

        //var resultado = numeros.Count();
        var resultado = numeros.Count(lambda => lambda > 10);

        Console.WriteLine(resultado);
       
    }

    public void AulaFirst()
    {
        var numeros = new int[] {10, 50, 30, 4, 15};

        //var resultado = numeros.First();
        //var resultado = numeros.First(lambda => lambda > 100);
        var resultado = numeros.FirstOrDefault(lambda => lambda > 100, -1);

        Console.WriteLine(resultado);
    }
}
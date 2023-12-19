namespace Modulo12;

public class TrabExcecao
{
    public void GerandoExcecao()
    {
        while(true)
        {
            Console.Write("Informe um numero: ");
            var numero = Console.ReadLine();
            var resultado = 500 / int.Parse(numero);

            Console.WriteLine("Resultado: " + resultado);
        }
    }

    public void TratandoExcecao()
    {
        while(true)
        {
            try{
                Console.Write("Informe um numero: ");
                var numero = Console.ReadLine();
                var resultado = 500 / int.Parse(numero);

                Console.WriteLine("Resultado: " + resultado);
            }catch(DivideByZeroException exeception){
                Console.WriteLine("Erro de divisão: " + exeception.Message);
                Console.WriteLine("Stack: " + exeception.StackTrace);
            }
            catch(Exception exeception){
                Console.WriteLine("Erro: " + exeception.Message);
                Console.WriteLine("Stack: " + exeception.StackTrace);
            }
        }
    }
}
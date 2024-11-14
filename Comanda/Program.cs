using System;
using ComandaApp.Services;

class Program
{
    static void Main()
    {
        var sistema = new SistemaComandas();

        int abertas = sistema.ContarComandasAbertas();
        int fechadas = sistema.ContarComandasFechadas();

        ComandaImp comandaMaiorValor = sistema.ObterComandaMaiorValor();

        Console.WriteLine($"Comandas Abertas: {abertas}");
        Console.WriteLine($"Comandas Fechadas: {fechadas}");
        if (comandaMaiorValor != null)
        {
            Console.WriteLine($"Comanda com Maior Valor: Comanda {comandaMaiorValor.Numero} com valor de {comandaMaiorValor.ValorTotal:C}");
        }
        else
        {
            Console.WriteLine("Não há comandas no sistema.");
        }
    }
}

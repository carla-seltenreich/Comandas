using System;
using System.Collections.Generic;
using System.Linq;

namespace ComandaApp.Services
{
    public class SistemaComandas
    {
        private List<ComandaImp> comandas;

        public SistemaComandas()
        {
            // Inicializa algumas comandas de exemplo
            comandas = new List<ComandaImp>
            {
                new ComandaImp(1, false, 50.75m), // Comanda 1 (aberta)
                new ComandaImp(2, true, 120.30m), // Comanda 2 (fechada)
                new ComandaImp(3, false, 75.50m), // Comanda 3 (aberta)
                new ComandaImp(4, true, 200.00m)  // Comanda 4 (fechada)
            };
        }

        // Contar comandas abertas
        public int ContarComandasAbertas()
        {
            return comandas.Count(c => !c.EstaFechada); // Comandas abertas
        }

        // Contar comandas fechadas
        public int ContarComandasFechadas()
        {
            return comandas.Count(c => c.EstaFechada); // Comandas fechadas
        }

        // Obter a comanda com maior valor
        public ComandaImp ObterComandaMaiorValor()
        {
            return comandas.OrderByDescending(c => c.ValorTotal).FirstOrDefault(); // Maior valor
        }
    }
}

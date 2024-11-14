namespace ComandaApp.Services
{
    public class ComandaImp
    {
        public int Numero { get; set; }
        public bool EstaFechada { get; set; }
        public decimal ValorTotal { get; set; }

        public ComandaImp(int numero, bool estaFechada, decimal valorTotal)
        {
            Numero = numero;
            EstaFechada = estaFechada;
            ValorTotal = valorTotal;
        }

        // Métodos para fechar e abrir a comanda, caso necessário
        public void FecharComanda(decimal valor)
        {
            EstaFechada = true;
            ValorTotal = valor;
        }

        public void AbrirComanda()
        {
            EstaFechada = false;
            ValorTotal = 0;
        }
    }
}

namespace List_DataStruct
{
    public class Cheque : Pagamento
    {
        public long numero; 
        public DateTime dataDeposito;

        public int situacao;


        public Cheque(long numero, int situacao)
        {
            this.numero = numero;
            this.situacao = situacao;
            this.dataDeposito = DateTime.Now;
            this.Apresentar();
            // this.total = 
            // this.RealizarPagamento(this.situacao);

        }


        public void Apresentar()
        {
            Console.WriteLine(
                $"\n"+
                $"Número do Cheque => {this.numero}"+
                $"Data de Depósito => {this.data}"
            );
        }

      

    }
}
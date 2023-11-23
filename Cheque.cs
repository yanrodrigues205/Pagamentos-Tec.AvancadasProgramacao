namespace List_DataStruct
{
    public class Cheque : Pagamento
    {
        public long numero; 
        public string data;

        public int situacao;

        public override void RealizarPagamento()
        {
            if(situacao == 1)
            {
                Console.WriteLine($"\nPagamento de Cheque Aprovado! \n Data {data} \n número do cheque: {numero}");
                base.RealizarPagamento();
            }
            else
            {
                 Console.WriteLine($"\nPagamento de Cheque Reprovado! \n Data {data} \n número do cheque: {numero}");
            }
            
        }

    }
}
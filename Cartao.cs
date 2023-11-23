
namespace List_DataStruct
{
    public class Cartao : Pagamento
    {
        //public string NumeroCartao { get; set; }
        public override void RealizarPagamento()
        {
            base.RealizarPagamento();
            //Console.WriteLine($"Pagamento por cartão, número do cartão: {NumeroCartao}");
        }
    }
}
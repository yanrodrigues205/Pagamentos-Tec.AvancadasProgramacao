using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace List_DataStruct
{
    public class Pagamento
    {
         public static decimal TotalPagamentos { get; private set; } = 0;
        public decimal Valor { get; set; }

        public virtual void RealizarPagamento()
        {
            TotalPagamentos += Valor;
            Console.WriteLine($"Realizando pagamento no valor de {Valor:C}");
            Console.WriteLine($"Total dos Pagamentos Atual => {TotalPagamentos:C}");
        }
        
    }
}
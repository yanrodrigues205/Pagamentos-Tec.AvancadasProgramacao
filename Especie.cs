using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace List_DataStruct
{
    public class Especie : Pagamento
    {
        public int troco;

        public override void RealizarPagamento()
        {
            if(troco <= 0)
            {
                Console.WriteLine("\n Pagamento em espécie. \n Sem troco!");
                base.RealizarPagamento();
            }
            else 
            {
                Console.WriteLine($"\n Pagamento em espécie. Troco a ser retornado => {troco:C}");
                base.RealizarPagamento();
            }
            
        }
    }
}
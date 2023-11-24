using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace List_DataStruct
{
    public class Pagamento
    {
        protected DateTime data = DateTime.Now;
        protected double total;

        public void RealizarPagamento(int resultado)
        {
            if(resultado >= 1)
            {
                Console.WriteLine(
                    $"\nPagamento de {this.total:C} Concluído com Sucesso!"+
                    $"\nData de conslusão de pagamento => {this.data}"
                );
            }
            else
            {
                Console.WriteLine(
                    $"\nPagamento de {this.total:C} Não foi Aprovado!"
                );
            }
        }
        
    }
}
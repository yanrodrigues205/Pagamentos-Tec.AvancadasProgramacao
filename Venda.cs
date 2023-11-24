using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace List_DataStruct
{
    public class Venda
    {
        private int codigo;
        private DateTime data;
        private double total;
        private List<ItemVenda> itens;

        public Venda(int codigo, List<ItemVenda> lista)
        {
            this.codigo = codigo;
            this.itens = lista;
            this.data = DateTime.Now;
        }

        public void Apresentar()
        {
            Console.WriteLine(
                $"\n"+
                $"Protocolo de Venda N-{this.codigo}\n"+
                $"Data de Venda = {this.data}"
            );

            

            for(int i =0; i < this.itens.Count; i++)
            {
                this.itens[i].Apresentar();
                this.total += this.itens[i].getSubtotal();
            }

            Console.WriteLine(
                $"Valor TOTAL => {this.getTotal():C}"
            );

            Cheque cheque = new Cheque(038843027, 1);
            
            
        }


        public double getTotal(){
            return this.total;
        }



    }
}
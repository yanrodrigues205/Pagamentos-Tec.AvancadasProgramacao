using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace List_DataStruct
{
    public class ItemVenda
    {

        private int quantidade;
        private double preco;

        private double subtotal;

        private Produto produto;


        public ItemVenda(int quantidade, Produto produto){
            this.quantidade = quantidade;
            this.produto = produto;
            this.preco = produto.GetPreco();
            this.Desconto();
        }

        public void Apresentar()
        {
        

            Console.WriteLine(
                $"\n"+
                $"Nome do produto => {this.produto.GetNome()}\n"+
                $"Valor por unidade => {this.produto.GetPreco():C}\n"+
                $"Quantidade comprada => {this.quantidade}\n"+
                $"SubTotal do item => {this.subtotal:C}\n"
            );
            
            if(this.quantidade >= 50)
            {
                Console.WriteLine(
                $"VOCÊ GANHOU 10% DE DESCONTO NESSE ITEM!"
                );
            }
            
           
        }
        public double getSubtotal()
        {
            return this.subtotal;
        }

        private void Desconto()
        {   
            
            this.subtotal = ( this.preco * this.quantidade );
            if(this.quantidade >= 50)
            {
                double desconto = ( ( this.preco * this.quantidade ) * 10 ) /100;
                this.subtotal = ( this.subtotal - desconto ); 
            }
        }
        
    }
}
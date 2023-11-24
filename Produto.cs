using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace List_DataStruct
{
    public class Produto
    {
        private long codigo;
        private string nome;
        private double preco;

        private int estoque;


        public Produto(long codigo, string nome, double preco, int estoque)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.preco = preco;
            this.estoque = estoque;
        }


        // public void Apresentar(){
        //     Console.WriteLine(
        //         "\n\n" +
        //         "Produto => "+ this.codigo + "\n" +
        //         "Nome =>" + this.nome + "\n" +
        //         "Preço => "+ this.preco + "\n" +
        //         "Estoque => "+this.estoque + "\n" 
        //     );
        // }

        public string GetNome()
        {
            return this.nome;
        }


        public double GetPreco()
        {
            return this.preco;
        }
    }
}
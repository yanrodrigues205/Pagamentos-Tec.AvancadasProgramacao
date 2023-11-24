using List_DataStruct;
using System;

namespace List_DataStruct
{
    public class Program
    {
        static void Main()
        {
           
            Produto produto1 = new Produto(1001, "Sapatênis", 59.90, 23);
            Produto produto2 = new Produto(1002, "Detergente", 7.80, 189);
            ItemVenda item1 = new ItemVenda(2, produto1);
            ItemVenda item2 = new ItemVenda(4, produto2);




            var listaItens = new List<ItemVenda>();
            listaItens.Add(item1);
            listaItens.Add(item2);

            Venda venda1 = new Venda(100023, listaItens);
            venda1.Apresentar();
            

        }
    }
}


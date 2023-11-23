using List_DataStruct;

Cheque cheque = new Cheque{ Valor = 10 , numero = 1223, data = "22/11/2023",situacao = 1 };
Cheque cheque2 = new Cheque{ Valor = 25 , numero = 1224, data = "22/11/2023", situacao = 1 };
Cheque cheque3 = new Cheque{ Valor = 25 , numero = 1225, data = "23/11/2023", situacao = 0 };


Especie especie = new Especie { Valor = 54, troco = 6 };

Especie especie2 = new Especie { Valor = 17, troco = 3 };

Console.WriteLine("rodou graças a Deus!");
cheque3.RealizarPagamento();
especie.RealizarPagamento();
cheque.RealizarPagamento();
especie2.RealizarPagamento();
cheque2.RealizarPagamento();

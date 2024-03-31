using System;

namespace Promocao {
    class Program {
        static void Main(string[] args) {
            double valor, desconto, total, litros;
            char combustivel;

            Console.Clear();
            Console.WriteLine("***** Promoção Abastecimento! *****");
            Console.WriteLine("Álcool");
            Console.WriteLine("Até 20L, 3% de desconto!");
            Console.WriteLine("Acima de 20L, 5% de desconto!");
            Console.WriteLine("Gasolina");
            Console.WriteLine("Até 20L, 4% de desconto!");
            Console.WriteLine("Acima de 20L, 6% de desconto!");
            Console.WriteLine(" ");

            Console.WriteLine("O que você irá abastecer? A - Álcool | G - Gasolina");
            combustivel = char.ToUpper(Console.ReadKey().KeyChar);

            Console.WriteLine("\nQuanto você irá abastecer?");
            litros = double.Parse(Console.ReadLine());

            if (combustivel == 'A') {
                valor = litros * 3.90;
                if (litros <= 20) {
                    desconto = valor * 0.03; // 3% de desconto
                } else {
                    desconto = valor * 0.05; // 5% de desconto
                }
                total = valor - desconto;
                Console.WriteLine("O preço a ser pago será: {0}", total);
            } else if (combustivel == 'G') {
                valor = litros * 4.50;
                if (litros <= 20) {
                    desconto = valor * 0.04; // 4% de desconto
                } else {
                    desconto = valor * 0.06; // 6% de desconto
                }
                total = valor - desconto;
                Console.WriteLine("O preço a ser pago será: {0}", total);
            } else {
                Console.WriteLine("Tipo de combustível inválido.");
            }
        }
    }
}
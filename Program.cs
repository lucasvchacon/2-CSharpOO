using System;

namespace introducaoOO
{
    class Program
    {
        static void Main(string[] args)
        {
            new ContaCorrente ();

            ContaCorrente contaDoLucas = new ContaCorrente();

            contaDoLucas.titular = " Lucas";
            Console.WriteLine(contaDoLucas.saldo);
            contaDoLucas.Sacar (50);
            Console.WriteLine(contaDoLucas.saldo);

            contaDoLucas.agencia = 1883;
            contaDoLucas.numero = 1920;
            contaDoLucas.saldo = 100;

            contaDoLucas.saldo += 200;

            Console.WriteLine(contaDoLucas.titular);
            Console.WriteLine("Agência: " + contaDoLucas.agencia);
            Console.WriteLine("Número: " + contaDoLucas.numero);
            Console.WriteLine("Saldo: " + contaDoLucas.saldo);

            contaDoLucas.Depositar(500);
            Console.WriteLine(contaDoLucas.saldo);

            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = " Gabriela";

            Console.WriteLine ( "Saldo do Lucas" + contaDoLucas.saldo);
            Console.WriteLine ( "Saldo da Gabriela" +contaDaGabriela.saldo);

            bool resultadoTransferencia = contaDoLucas.Tranfesrir(200, contaDaGabriela);

            Console.WriteLine ( "Saldo do Lucas" + contaDoLucas.saldo);
            Console.WriteLine ( "Saldo da Gabriela" +contaDaGabriela.saldo);

            Console.WriteLine("Resultado tranferência" + resultadoTransferencia);

        
            Console.ReadLine();

        }
    }
}

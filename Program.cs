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

            

           
            



            Console.ReadLine();

        }
    }
}

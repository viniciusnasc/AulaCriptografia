using System;

namespace AulaCriptografia
{
    class Program
    {
        static void Main(string[] args)
        {
            /* //CHAVES SIMETRICAS
            Console.WriteLine("Utilizando chaves simtericas");
            Console.WriteLine("Algoritmo AES");
            // AES = Advanced Encryption Standard

            CriptoSimetrica s = new();
            Console.WriteLine("Digite uma mensagem para ser criptografada: ");
            string msg = "Vinicius";
            Console.WriteLine("Digite outra mensagem para ser criptografada: ");
            string msg2 = "Vinicius";

            string msgCripto1 = s.EncryptData(msg, "ats");
            string msgCripto2 = s.EncryptData(msg2, "atos");

            Console.WriteLine(msgCripto1);
            Console.WriteLine(msgCripto2);

            msgCripto1 = s.DecryptData(msgCripto1, "atos");
            msgCripto2 = s.DecryptData(msgCripto2, "atos");


            Console.WriteLine(msgCripto1);
            Console.WriteLine(msgCripto2);
            */

            // CHAVES ASSIMETRICAS
            Console.WriteLine("Utilizando chaves assimtericas");
            CriptoAssimetrica a = new();

            Console.WriteLine("Digite uma mensagem para ser criptografada: ");
            string msg = "Vinicius";
            Console.WriteLine("Digite outra mensagem para ser criptografada: ");
            string msg2 = "Vinicius";

            string dadoCripto = a.encrypt(msg);
            Console.WriteLine(dadoCripto);

            dadoCripto = a.decrypt(dadoCripto);
            Console.WriteLine(dadoCripto);
        }
    }
}

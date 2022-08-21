
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {

            //instanciando classe Cliente com o nome Henrique
            ContaCorrente Henrique = new ContaCorrente();
            Cliente Henrique1 = new Cliente();

            //Informações da conta Henrique
            Henrique1.nome ="Henrique Decarli Tavares";
            Henrique.agencia = 356962458;
            Henrique.numero = 70;
            Henrique.saldo = 2000;

            //instanciando classe Cliente com o nome Diana
            ContaCorrente Fulano = new ContaCorrente();
            Cliente Fulano1 = new Cliente();

            //Informações da conta Diana
            Fulano1.nome = "Fulano";
            Fulano.agencia = 375689369;
            Fulano.numero = 90;
            Fulano.saldo = 3000;

            //Printando informações na tela de Henrique
            Console.WriteLine("TITULAR: " + Henrique.titular);
            Console.WriteLine("AGENCIA: " + Henrique.agencia);
            Console.WriteLine("NUMERO: " + Henrique.numero);
            Console.WriteLine("SALDO: " + Henrique.saldo);
            Console.WriteLine();
            //Printando informações na tela de Diana
            Console.WriteLine("TITULAR: " + Fulano.titular);
            Console.WriteLine("AGENCIA: " + Fulano.agencia);
            Console.WriteLine("NUMERO: " + Fulano.numero);
            Console.WriteLine("SALDO: " + Fulano.saldo);
            Console.WriteLine();

            //quando criamos classe no C#, nos não temos um tipo de valor e sim um tipo de referencia;
            //ou seja, nesse caso nos estamos tentando comparar uma unidade de memoria onde a variavel esta armazenada e não a variavel em si, por isso o false;
            //uma unidade de memoria nunca sera igual outra unidade de memoria
            Console.WriteLine(Henrique == Fulano);
            Console.WriteLine();
            Console.WriteLine("==============================================================================================");
            //=================================================================================================================================================================

            //utilizando função criada para Sacar

            Console.WriteLine("Saldo antes do saque R$ " + Henrique.saldo);

            // nesse caso abrimos () pois se trata de uma variavel (Sacar) que é uma função situada na classe "ContaCorrente"
            //armazenar o valor do saque na variavel\função "resultadoSaque" do mesmo tipo da função " bool",para podermos imprimir a info na tela do cliente
            bool resultadoSaque = Henrique.Sacar(500);

            // vai retonar true ou false, dependendo do valor do saque, se saque foi mmaior que saldo, retorna false caso contrario retorna True
            Console.WriteLine(resultadoSaque);

            Console.WriteLine("Saldo depois do saque R$ " + Henrique.saldo);
            Console.WriteLine();
            Console.WriteLine("==============================================================================================");
            //=================================================================================================================================================================

            //utilizando função criada para Depositar


            Henrique.Depositar(500);

            Console.WriteLine("valor apos deposito R$ " + Henrique.saldo);
            Console.WriteLine();
            Console.WriteLine("==============================================================================================");
            //=================================================================================================================================================================

            //utilizando função criada para Transferir

            Console.WriteLine("saldo Henrique antes da transferencia R$ " + Henrique.saldo);
            Console.WriteLine("saldo Diana antes do recebimento de transferencia R$ " + Fulano.saldo);
            Console.WriteLine();

            // como função criada para Transferir utiliza dois parametros, tambem adicionamos os dois parametros na mesma ordem da função
            Henrique.Transferir(200, Fulano);
            Console.WriteLine("saldo Henrique apos transferencia R$ " + Henrique.saldo);
            Console.WriteLine("saldo Diana apos recebimento de transferencia R$ " + Fulano.saldo);
            Console.WriteLine();
            Console.WriteLine("==============================================================================================");

            //=================================================================================================================================================================

            

            //referenciando que a variavel "titular" da classe "ContaCorrente" é a mesma variavel "nome" da classe "CLiente"
            Henrique.titular = Henrique1;
            Henrique1.cpf = "35693245870";
            Henrique1.profissao = "Desenvolvedor";

            Console.WriteLine(Henrique.titular.nome);
            Console.WriteLine(Henrique1.nome);



            Console.ReadLine();


        }
    }
}

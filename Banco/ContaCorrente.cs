using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


 
namespace Banco
{
    //classe criada para a execução das funcionalidades da conta corrente
    class ContaCorrente
    {
        public Cliente titular;// compartilhando atributo em duas classes, agora a classe "ContaCorrente" esta utilizando o mesmo atributo da classe "Cliente"
        public int agencia;
        public int numero;
        public double saldo;

        //Função para Sacar
        public bool Sacar (double valor)
        {
            //utilizamos o "this" para informar ao programa que quero acessar o "saldo" do objeto (instancia)
            if (this.saldo < valor)
            {
                // vai retornar false se o valor armazenado na varialvel "saldo" for menor que o valor da variavel "valor"
                return false;

            }
            else
            {
                //vai subtrair o valor armazenado na variavel "valor" da variavel "saldo" caso a condição retorne verdadeira
                this.saldo -= valor;
                return true;
            }

        }
        // Função para Depositar
        public void Depositar(double valor)
        {
            //vamos acrescentar valor ao saldo
            this.saldo += valor;
    
        }
        //Função para Trasnferir
        public bool Transferir (double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }else
            {
                //função vai subtrair o valor do saldo da conta de origem
                this.saldo -= valor;

                //função que vai depositar o valor retirado do saldo da conta origem para a conta de destino, reutilizando a função de Depositar ja criada acima
                contaDestino.Depositar(valor);
                return true;
            }


        }



    }

    
}

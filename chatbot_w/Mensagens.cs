using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chatbot_w
{
    public class Mensagens
    {
        public void Iniciar(){
            while (true)
            {
                Console.WriteLine("Olá. Você está no atendimento online da ZapZum Fibra Óptica.");
                Console.WriteLine("Para começarmos, escolha uma das opções abaixo: ");
                Console.WriteLine("1: Preciso de suporte técnico");
                Console.WriteLine("2: Preciso de suporte financeiro");
                Console.WriteLine("3: Desejo alterar ou cancelar meu plano");
                Console.WriteLine("4: Ainda não sou cliente e desejo me informar sobre os planos");
                Console.WriteLine("5: Sair");
            }
        }
    }
}
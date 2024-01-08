using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace chatbot_w
{
    public class Mensagens
    {
        public void Iniciar()
        {
            while (true)
            {
                int Escolha;

                Console.WriteLine("Olá. Você está no atendimento online da ZapZum Fibra Óptica.");
                Console.WriteLine("Para começarmos, escolha uma das opções abaixo: ");
                Console.WriteLine("1: Preciso de suporte técnico");
                Console.WriteLine("2: Preciso de suporte financeiro");
                Console.WriteLine("3: Desejo alterar ou cancelar meu plano");
                Console.WriteLine("4: Ainda não sou cliente e desejo me informar sobre os planos");
                Console.WriteLine("5: Sair");

                if (int.TryParse(Console.ReadLine(), out Escolha))
                {
                    switch (Escolha)
                    {
                    case 1:                    
                        Console.WriteLine("..."); // depois encaixar os métodos certos
                        break;                    

                    case 2:                   
                        Console.WriteLine("..."); // depois encaixar os métodos certos
                        break;

                    case 3:
                        Console.WriteLine("..."); // depois encaixar os métodos certos
                        break;
                    
                    case 4:
                    Console.WriteLine("..."); // depois encaixar os métodos certos
                        break;
            
                    case 5:
                        Console.WriteLine("..."); // depois encaixar os métodos certos
                        return;
                    }
                }
            }
        }
    }

    public class Suporte_Tec
    {
        public void Executar()
        {
            //Depois de criar a estrutura básica, vou usar o conector MySQL 
            //para buscar as informações do cliente em uma tabela
            string NomeCliente;
            
            Console.WriteLine ("Olá. Bem vindo ao Suporte ao Cliente.");
            Console.WriteLine ("Para comerçamos, digite seu nome completo sem abreviações");
            NomeCliente=Console.ReadLine();
            // aqui vou adicionar um if para verificar se o cliente realmente existe na tabela MySQL
        }
    } // chave public class Suporte_Tec

}// chave namespace
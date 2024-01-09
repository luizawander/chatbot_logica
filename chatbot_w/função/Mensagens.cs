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
                        new Suporte_Tec().Executar();
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
    public class Suporte_financeiro
    {
        public void Executar()
        {
        }// void
    }// class suporte_financeiro

} // chave namespace
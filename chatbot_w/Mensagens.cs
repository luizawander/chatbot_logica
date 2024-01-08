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
            while (true)
            {
                int Esc1;

                Console.WriteLine($"{NomeCliente}, escolha uma das opções abaixo: " );
                Console.WriteLine("1: Minha internet não está funcionando.");
                Console.WriteLine("2: Problemas de velocidade de internet.");
                Console.WriteLine("3: Meu roteador não liga.");
                Console.WriteLine("4: Identifiquei que meu fio está rompido.");
                Console.WriteLine("5: Desejo mudar a senha da minha rede.");
                Console.WriteLine("6: Desejo falar com um atendente da Zapzum");
                Console.WriteLine("7: Sair");

                if (int.TryParse(Console.ReadLine(), out Esc1))
                {
                     switch (Esc1)
                     {
                         case 1:
                            Console.WriteLine("Primeiro, tente reiniciar seu roteador ao menos 2 vezes.");
                            Console.WriteLine("Se o problema persistiu, digite SIM ");
                            string Resp = Console.ReadLine();
                         // verificar depois se caso a resposta for dada em letra minuscula, isso irá dar erro na execução.
                         if (Resp == "SIM")
                        {
                             Console.WriteLine("Certo. Iremos agendar um atendimento presencial de um técnico da ZapZum.");
                                //aqui fazer outra ver na TBL para informar escrever o endereço do cliente
                                Console.WriteLine ("Confirme seu endereço digitando SIM :--puxar o endereço na tbl--");
                                string Resp2=Console.ReadLine();

                                 if(Resp2=="SIM")
                                {
                                    Console.WriteLine("Ok. Em até 48 horas um dos nossos técnicos irá visitar sua residência.");
                                    Console.WriteLine("Certifique-se que tenha uma pessoa durante os nosso horário de atendimento (9h-18h).");
                                    Console.WriteLine("Além disso, nosso atendimento só é feito mediante a presença de um responsável maior de idade");
                                    break;
                                }

                                 else 
                                {
                                    Console.WriteLine("Certo, parece que temos um erro com seus dados. Iremos te encaminhar para o atentimento com um dos nossos técnicos. Aguarde um minuto");
                                }
                        }
                        else if (Resp == "NÃO")
                        {
                            Console.WriteLine("Ok. Encerramos então nosso atendimento. Tenha um ótimo dia.");
                            break;
                        }                   
                         break;
                    }
                } 
            }  // CHAVE WHILE  
        }
    } // chave public class Suporte_Tec

} // chave namespace
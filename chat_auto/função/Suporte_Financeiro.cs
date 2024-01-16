using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chatbot_w.função
{
    public class Suporte_Financeiro
    {
        public void Executar()
        {
            Console.WriteLine ("Olá. Bem vindo ao Suporte Técnico.");
            Console.WriteLine ("Para comerçamos, digite seu CPF, apenas com números.");
            string NomeCliente=Console.ReadLine();
            // aqui vou adicionar um if para verificar se o cliente realmente existe na tabela SQL
            while (true)
            {
                int Esc1;

                Console.WriteLine($"{NomeCliente}, escolha uma das opções abaixo: " );
                Console.WriteLine("1: Preciso da segunda via no meu bolheto.");
                Console.WriteLine("2: consultar faturas em aberto.");
                Console.WriteLine("3: Negociar débitos.");
                Console.WriteLine("4: Desejo falar com um atendente da Zapzum");
                Console.WriteLine("5: Sair");

                if (int.TryParse(Console.ReadLine(), out Esc1))
                {
                   switch (Esc1)
                   {
                        case 1:
                            Console.WriteLine("Certo. Te encaminharemos uma segunda via de seu bolheto através do seu email cadastrado.");
                            Console.WriteLine("Confirma seu Email? _________. Se sim, digite 1. Se não, 2."); // puxar email da tabela
                                    
                                    string Resp6 = Console.ReadLine();

                                    if (Resp6=="1")
                                    {
                                        Console.WriteLine("Ok, te encaminharemos o email e em seguida as instruções da alteração dentro de alguns instantes.");
                                        Console.WriteLine("Caso tenha algum problema com o recebimento do email, peça parar falar com um dos nossos atendentes.");
                                        new Sair().Executar();
                                    }
                                    else if (Resp6=="2")
                                    {
                                        new ErroDados().Executar();
                                    }
                        break;


                        case 2:
                            Console.WriteLine ("Certo, abaixo está o resumo de suas faturas em aberto");
                            Console.WriteLine ("");
                            //puxar da tabela as faturas em aberto

                        break;


                        case 3:
                            Console.WriteLine ("OK, parece que você deseja negociar seus débitos em atraso."); 
                            Console.WriteLine ("");
                            // nesse caso, vamos pegar da tebela a informação das dívidas em atraso e oferecer ao cliente a opção de pagar o valor inteiro, sem juros. Ou pagar metade da dívida e parcelar a outra metade com 3% de juro. Ou parcelar toda a dívida com 6% de juros
                        break;


                        case 4:
                            new Atendente().Executar();
                        break;


                        case 5:
                            new Sair().Executar();
                        break;
                   }
                }   



            }//while
        }// void
    }// class suporte_financeiro

    
}//namespace
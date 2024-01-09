using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chatbot_w
{
    // instruções de login
    public class Manual
    {
        public void Executar()
        {
            Console.WriteLine("Ok, você escolheu a opção manual. Aqui estão as instruções: ");
                                Console.WriteLine("Passo 1: Abra o link abaixo: "); // aqui simular um link da provedora 
                                Console.WriteLine("Passo 2: entre com seu login no portal da ZapZum e clique nos 3 pontos no canto superior direito da sua tela. Caso não saiba seu login e sua senha, digite 1. Em seguidas te encaminharemos um email contendo suas informações de acesso.");
                                Console.WriteLine("Passo 3: Vá em configações e selecione a opção 'Alterar acesso de rede' e por fim, faça a mudança do nome de sua rede ou de sua senha");
                                Console.WriteLine("Caso tenha conseguido realizar a alteração, digite 2 e encerraremos nosso atentimeno");

                                string Resp7= Console.ReadLine();

                                if (Resp7== "2")
                                {
                                    new Encerrar().Executar();
                                }
        }
    }
}

//instrução de problemas com o cadastro
public class ErroDados
{
    public void Executar()
    {
        Console.WriteLine("Certo, parece que temos um erro com seus dados. Iremos te encaminhar para o atentimento com um dos nossos técnicos. Aguarde um minuto");
    }
}

//instrução de encerrar o atendimento
public class Encerrar
{
    public void Executar()
    {
        Console.WriteLine("Ok. Encerramos então nosso atendimento. Tenha um ótimo dia.");
        Environment.Exit(0);
    }
}    

public class VisitaTec
{
    public void Executar()
    {
        Console.WriteLine("Ok. Em até 48 horas um dos nossos técnicos irá fazer a visita técnica.");
        Console.WriteLine("Certifique-se que tenha uma pessoa em sua residência durante os nossos horário de atendimento (9h-18h).");
        Console.WriteLine("Além disso, nosso atendimento só será feito mediante a presença de um responsável maior de idade.");
        Environment.Exit(0);
    }
}
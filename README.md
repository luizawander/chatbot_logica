## READme provisório.

Oi, oi. 

Este é um projeto no qual tem como objetivo, sobretudo, treinar minha lógica da programação na linguagem C#, usando o .NET 8. 

Ele consiste em criar um chat automatizado que simula o atendimento por whatsapp de uma empresa de internet nomeada de "ZapZum".

Além da lógica, também quero tentar usar o conector do .NET com o MySQL e aprender a fazer as API's necessárias para o funcionamento do chat.


**15/01/2024**

Olá.

Por enquanto irei usar aqui para fazer atualizações diárias dos meus avanços e dificuldades em concretizar este projeto experimental. 

Após a conclusão dele, irei organizar todas as informações acerca dos seus passos. 

Inicialmente, como podem ver, eu criei uma estrutura bem básica da mensagens no chat. 
Separei em algumas classes, que fazem referencia as possbibilidades de resolução dos problemas, como "assistencia técnica".
Também fiz uma classe que auxiliasse em certas mensagens repetidas, como a solicitação de se falar com um atendente. 

Além disso, também criei uma tabela no MySQL, no qual vou a conectar no programa para que certas informações fictícias sejam utilizadas. 
Vou deixar o link do script para que possam acessar: https://docs.google.com/document/d/1sSJhSREyk5d8Esi5WXqm3PVeIZrdDXIst6R2oDgDElo/edit?usp=sharing

Eu ando tendo algumas dificuldades em criar a tabela, visto que é a primeira vez que faço um banco de dados mais "complexo". 
Fóruns na internet tem sido meus aliados nesse processo. 
Apesar de estressante as vezes, entendo que os erros fazem parte e tudo bem demorar a solucionar algum problema :)


**16/01/2024**

Hoje finalizei a estrutura da tabela no MySQL e inclui a maioria dos dados, amanhã vou só fazer alguns ajustes neles e já voltar para o código C# em si.

Além disso, também corrigi um problema que tive após alterar o nome de alguns arquivos em meu PC. Como mudei o nome, o C# extensions não estava reconhecedo o projeto. Precisei fazer uma alteração manual no chat_auto.sln e lá atualizei os nomes para reconhecer os caminhos necessários.


**17/01/2024** 

Estou tendo várias dificuldades de integrar minha tabela com o projeto, visto que seria muito mais simples se eu tivesse feito a tabela antes do projeto e já criar o projeto conectando com o MySQL. Estou cogitando duplicar os arquivos em uma ramificação e ir só me baseando no original para refazer.

**aviso**
resolvi que vou deixar esse projeto só contendo o treino da lógica da programação e vou criar outro arquivo para fazer o projeto do chat automatizado mais complexo.

// Capacidade: 
// Utilizar o paradigma da programação orientada a objetos 
// Tipo: Formativa


// Faça em sua máquina utilizando os mesmos conceitos dado em aula.
// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.
// Envie o link do repositório como entrega desta atividade.

using celular;

Celulares Celular = new Celulares();

Console.Write($"Qual a cor do celular ?");
Celular.Cor = Console.ReadLine();

Console.Write($"Qual é o modelo do celular ?");
Celular.Modelo = Console.ReadLine();

Console.Write($"Qual é o tamanho do celular ?");
Celular.Tamanho = Console.ReadLine();

Console.Write($"Deseja ligar o celuar ? s|n ?");
string? resposta = Console.ReadLine();

switch (resposta)
{
    case "s": Celular.Ligar();
        break;
    case "n": Celular.Desligar();
        break;
    default:
        break;
}

while(Celular.Ligado == true)
{
    Console.Write($"Deseja fazer uma ligação? s|n ?");
    resposta = Console.ReadLine();
    
    if (resposta == "s")
    {
        Celular.FazerLigacao();
    }
    else if (resposta == "n")
    {
        Console.WriteLine($"OK");
        
        
    }

    Console.Write($"Deseja enviar mensagem ?");
    resposta = Console.ReadLine();
    
    if (resposta == "s")
    {
        Celular.EnviarMensagem();
    }
    else
    {
        Console.Write($"OK");
        
    }

    Console.Write($"Deseja desligar o celular ?");
    resposta = Console.ReadLine();
    
    if (resposta == "s")
    {
        Celular.Desligar();
    }
    else
    {
        Celular.Ligado = true;
    }
    
    
    
}







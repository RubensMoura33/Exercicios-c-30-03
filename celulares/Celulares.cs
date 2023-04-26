// Capacidade: 
// Utilizar o paradigma da programação orientada a objetos 
// Tipo: Formativa


// Faça em sua máquina utilizando os mesmos conceitos dado em aula.
// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.
// Envie o link do repositório como entrega desta atividade.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.
// Envie o link do repositório como entrega desta atividade.

namespace celular
{
    public class Celulares
    {
        public string? Cor;
        public string? Modelo;
        public string? Tamanho;
        public bool? Ligado;

        public string Ligar()
        {
            Ligado = true;
            Console.WriteLine($"O celular está ligado");
            
            
        return "";
        }

        public string Desligar()
        {
            Console.WriteLine($"O celular está desligado");
            Ligado = false;
            
            return "";
        }

        public string FazerLigacao()
        {
            Console.WriteLine($"Fazendo Ligação");
            
            return "";
        }

        public string EnviarMensagem()
        {
            Console.WriteLine($"Enviando Mensagem");
            
            return "";
        }

    }
}
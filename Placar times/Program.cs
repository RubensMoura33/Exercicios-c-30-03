Console.WriteLine($"Calculador de placar");

Console.WriteLine($"Informe a quantidades de gols da primeira equipe");
float Gols1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe a quantidades de gols da segunda equipe");
float Gols2 = float.Parse(Console.ReadLine());


if (Gols1 > Gols2)
{
    Console.WriteLine($"a primeira equipe venceu");
    
}

else if (Gols2 > Gols1)
{
    Console.WriteLine($"a segunda equipe equipe venceu");
    
}

else if (Gols2 == Gols1)
{
    Console.WriteLine($"O jogo empatou");
    
}

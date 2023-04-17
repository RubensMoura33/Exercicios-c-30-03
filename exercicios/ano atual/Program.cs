 Console.WriteLine($"Programa para verificar se pode votar ou nao");

Console.WriteLine($"Digite seu nome");
string? nome =Console.ReadLine();

Console.WriteLine($"Digite seu ano de nascimento");
int anoNasc = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o ano atual");
int anoAtual = int.Parse(Console.ReadLine());


if ( anoAtual - anoNasc > 15)
{
    Console.WriteLine($"Pode votar");
    
}
else
{
    Console.WriteLine($"nao pode votar");
    
}



 
 
Console.WriteLine($"Bem vindo");

Console.WriteLine($"Digite a senha:");
 float senha = float.Parse (Console.ReadLine());

if (senha == 1234)
{
    Console.WriteLine($"ACESSO    PERMITIDO");
    
}

else{
    Console.WriteLine($"ACESSO    NEGADO");
    
}

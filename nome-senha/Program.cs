Console.WriteLine($"Digite nome de usuario");
string? usuario = Console.ReadLine();

Console.WriteLine($"Digite uma senha");
string? senha = Console.ReadLine();

while (usuario == senha)
{
    Console.WriteLine($"usuario e senha nao podem ser igual, digite a senha novamente:");
    senha = Console.ReadLine();
}

Console.WriteLine($"Sua conta foi salva");




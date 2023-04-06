Console.WriteLine($"Digite uma nota de 0 a 10");
int nota = int.Parse(Console.ReadLine());

while (nota <0 || nota >10)
{
    Console.WriteLine($"Digite uma nota entre 0 e 10");
    nota = int.Parse(Console.ReadLine());
}

Console.WriteLine($"Nota recebida");



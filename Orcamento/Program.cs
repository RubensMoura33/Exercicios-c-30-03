Console.WriteLine($"Bem vindo ao nosso sistema");

Console.WriteLine($"Informe o valor do seu salario");
float salario = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe os gastos desse mes");
float gastos = float.Parse(Console.ReadLine());

float orçamento = (salario - gastos);

if ( orçamento >= 0) 
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Dentro do orçamento");
    Console.ResetColor();
}

else {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Passou do orçamento ");
    Console.ResetColor();
}
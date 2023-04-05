//Faça um programa que leia e valide as seguintes informações:

// 1. Nome: diferente de vazio;

// 2. Idade: entre 0 e 100 anos;

// 3. Salário: maior que zero;

// 4. Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a));

Console.WriteLine($"Digite seu nome");
string nome = Console.ReadLine();

Console.WriteLine($"Digite sua idade");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite seu salário");
float salario = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite 'c' para casado, 's' para solteiro, 'v' para viuvo ou 'd' para divorciado");
char estadoCivil = char.Parse(Console.ReadLine().ToLower());

while (nome.Length == 0)
{
    Console.WriteLine($"Digite seu nome");
     nome = Console.ReadLine();   
}

while (idade > 100)
{
    Console.WriteLine($"Digite uma idade entre 0 e 100 anos");
    idade = int.Parse(Console.ReadLine()); 
}

while (salario <=0)
{
    Console.WriteLine($"Digite um salario acima de 0 reais");
    salario = float.Parse(Console.ReadLine());
}

while (estadoCivil != 's' && estadoCivil != 'c'&& estadoCivil != 'v' && estadoCivil != 'd')
{
    Console.WriteLine($"Digite 'c' para casado, 's' para solteiro, 'v' para viuvo ou 'd' para divorciado");
    estadoCivil = char.Parse(Console.ReadLine());
}
Console.WriteLine($"Dados recebidos com sucesso");





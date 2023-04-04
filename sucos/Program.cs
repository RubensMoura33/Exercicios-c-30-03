Console.WriteLine(@$"
Escolha a sua bebida
'1' para suco de limao
'2' para suco de laranja
'3' para suco de uva
'4' para suco de manga"
);

Console.WriteLine($"Digite o sabor do suco");
char? suco = char.Parse(Console.ReadLine().ToLower());

Console.WriteLine($"Deseja acompanhar gelo? sim ou nao");
string? gelo =Console.ReadLine().ToLower();

string? sucoSabor = "suco nao selecionado";


switch (gelo)
{
    case "sim":
    gelo = "com gelo";
        break;

    case "nao":
    gelo = "sem gelo";
        break;

    default:
    Console.WriteLine($"gelo nao selecionado");
    
        break;
}



switch (suco)
{
    case '1':
    sucoSabor = "limao";
    Console.WriteLine($"voce escolheu suco de {sucoSabor} {gelo}");
    
        break;
    case '2':
    sucoSabor = "laranja";
    Console.WriteLine($"voce escolheu suco de {sucoSabor} {gelo}");
    
        break;
    case '3':
    sucoSabor = "uva";
    Console.WriteLine($"voce escolheu suco de {sucoSabor} {gelo}");
    
        break;
    case '4':
    sucoSabor = "manga";
    Console.WriteLine($"voce escolheu suco de {sucoSabor} {gelo}");
    
        break;
    default: Console.WriteLine($"suco nao selecionado");
    
        break;
}



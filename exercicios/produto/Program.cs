// 3 - Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
// preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
// desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
// - Se quantidade &lt;= 5 o desconto será de 2%
// - Se quantidade &gt; 5 e quantidade &lt;=10 o desconto será de 3%
// - Se quantidade &gt; 10 o desconto será de 5%
// Dica: utilize if / else if / else

Console.WriteLine($@"
Confira nossa tabela de preços:
Nike shox TL R$500,00
Vapor max R$350,00
Digite 'N' para adquirir o Nike shox TL
Digite 'V' para adquirir o Vapor max
");
char tenis = char.Parse(Console.ReadLine().ToLower());

 while (tenis != 'n' && tenis != 'v' )
    {
     Console.WriteLine(@$"
     Digite 'N' para adquirir o Nike shox TL
     Digite 'V' para adquirir o Vapor max");
    tenis = char.Parse(Console.ReadLine().ToLower());
       
    }

Console.WriteLine($"Quantas unidades");
int quantidades = int.Parse(Console.ReadLine());

float preçoNike = 500;

float preçoVapor =350;

float valorAPagar = 0;


if (tenis == 'n')
{
   if (quantidades<=5)
   {
    valorAPagar = (preçoNike*0.98F)*quantidades;

   }
   else if (quantidades>5 && quantidades<=10)
   {
    valorAPagar = (preçoNike*0.97F)*quantidades;
   }
   else 
   {
    valorAPagar = (preçoNike*0.95F)*quantidades;
   }
}


else if(tenis == 'v')
{
   if (quantidades<=5)
   {
    valorAPagar = (preçoVapor*0.98f)*quantidades;

   }
   else if (quantidades>5 && quantidades<=10)
   {
    valorAPagar = (preçoVapor*0.97F)*quantidades;
   }
   else 
   {
    valorAPagar = (preçoVapor*0.95F)*quantidades;
   }
}

else{
    Console.WriteLine($"erro inesperado");
    
}

Console.WriteLine($"Valor da compra R${valorAPagar}");



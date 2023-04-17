// 2 - Um posto está vendendo combustíveis com a seguinte tabela de descontos:
// Álcool:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro
// Gasolina:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro

// Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
// da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
// sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
// Dica: utilize switch case e funções/métodos para otimizar o algorítimo.


Console.WriteLine($"Bem vindo ao nosso posto");

Console.WriteLine($"DIgite 'G' para abastecer com gasolina ou 'A' para álcool");
char combustivel = char.Parse(Console.ReadLine().ToLower());

Console.WriteLine($"Quantos litros?");
float litros = float.Parse(Console.ReadLine());



static float preco (char combustivel, float litros)
{

if (combustivel == 'g')
{
  if (litros <=20)
  {
   return litros*5.30F - litros*5.30F*0.04F;
  }  
  else
  {
    return litros*5.30F - litros*5.30F*0.06f;
  }
}
else if (combustivel == 'a')
{
  if (litros <=20)
  {
   return litros*4.90F - litros*4.90F*0.03F;
  }  
  else
  {
    return litros*4.90F - litros*4.90F*0.05F;
  }
}
else
{
    return 0;
}
}
Console.WriteLine($"sua compra ficou no valor de {preco(combustivel,litros)}");



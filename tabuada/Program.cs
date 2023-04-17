Console.WriteLine($"Tabuada");

Console.WriteLine($"Digite um numero, para descobrir sua tabuada");
float? numero = float.Parse(Console.ReadLine());

for (float i =1; i <=10; i++)

{
    Console.WriteLine($"{numero}x{i}={numero*i}");
    
}




Console.WriteLine("*******************************");
Console.WriteLine("Contagem dos numeros inteiros");
Console.WriteLine("*******************************");

List<int> numerosInteiros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


for (int i = 0; i < numerosInteiros.Count; i++)
{
    Console.WriteLine(numerosInteiros[i] + "\n");
}


Console.WriteLine("****************************");
Console.WriteLine("Contagem dos numeros par");
Console.WriteLine("***************************");

List<int> numerosPares = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

foreach (int i in numerosPares)
{
    if (numerosPares[i] % 2 == 0)
    {
        Console.WriteLine(numerosPares[i] + "\n");
    }
}

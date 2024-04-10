using System;
using System.Collections.Generic;
using System.Linq;

var animals = new List<string>();
animals.Add("🐒 - Macaco");
animals.Add("🐢 - Tartaruga");
animals.Add("🐫 - Camelo");
animals.Add("🐳 - Baleia");
animals.Add("🐄 - Vaca");
animals.Add("🦩 - Pelicano");
animals.Add("🦆 - Pato");

// Primeiro elemento
Console.WriteLine(animals.First());
Console.WriteLine(animals.FirstOrDefault());//Primeiro ou valor padrão;Pode informar o valor padrão

// Verificar se um elemento existe
Console.WriteLine(animals.Any(x=>x== "🐳 - Baleia"));

//Verificar se todos os elementos tem certa condições
Console.WriteLine(animals.All(x=>x=="🐳 - Baleia"));

//Contar
Console.WriteLine(animals.Count());
Console.WriteLine(animals.Count(x=>x=="🦆 - Pato"));

//Buscar na lista com o indice
Console.WriteLine(animals.ElementAt(3));

//Pegar determinado indice
foreach(var animal in animals.Take(2))//Top 2 animals.Take(..3);Ultimos 3 animals.Take(4..6);4 ao 6
{
    Console.WriteLine(animal);
}

//Where aonde acontecer
foreach (var animal in animals.Where(x=>x=="🦆 - Pato"))
{
    Console.WriteLine(animal);
}

//Espera um unico elemento, caso contrario lança uma exception
Console.WriteLine(animals.Single(x=>x== "🐫 - Camelo"));

//Ultimo elemento
Console.WriteLine(animals.Last());

//Pular numero de primeiros itens da lista
foreach (var animal in animals.Skip(2))
    Console.WriteLine(animal);
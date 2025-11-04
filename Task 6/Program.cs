using System.Collections.Generic;

List<string> fruits = new List<string> { "Strawberry", "Pineapple", "Litchi" };

fruits.Add("Orange");

fruits.Remove("Pineapple");

Console.WriteLine("Fruits in the list:");
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}

Dictionary<int, string> fruitDictionary = new Dictionary<int, string>
{
    { 1, "Strawberry" },
    { 2, "Litchi" },
    { 3, "Orange" }
};

fruitDictionary.Add(4, "Grapes");

Console.WriteLine("\nFruits in the dictionary:");
foreach (var pair in fruitDictionary)
{
    Console.WriteLine($"ID: {pair.Key}, Name: {pair.Value}");
}
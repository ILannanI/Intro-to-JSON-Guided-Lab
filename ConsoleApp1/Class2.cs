using Newtonsoft.Json;
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<Person> people = new List<Person>
        {
            new Person("Alice", 25, "alice@example.com", true),
            new Person("Bob", 30, "bob@example.com", false),
            new Person("Charlie", 22, "charlie@example.com", true)
        };

        string jsonString = JsonConvert.SerializeObject(people, Formatting.Indented);
        Console.WriteLine("Serialized JSON:\n" + jsonString);

        try
        {
            List<Person> deserializedPeople = JsonConvert.DeserializeObject<List<Person>>(jsonString);
            Console.WriteLine("\nDeserialized People:");
            foreach (var person in deserializedPeople)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}, Email: {person.Email}, IsStudent: {person.IsStudent}");
            }
        }
        catch (JsonSerializationException ex)
        {
            Console.WriteLine("Serialization Error: " + ex.Message);
        }
        catch (JsonReaderException ex)
        {
            Console.WriteLine("JSON Reader Error: " + ex.Message);
        }
    }
}

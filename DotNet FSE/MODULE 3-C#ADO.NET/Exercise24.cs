using System;
using System.IO;
using System.Text.Json;

public class Exercise24
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }

    public static void Main()
    {
        User user = new User { Name = ""Alice"", Age = 30, Email = ""alice@example.com"" };

        string json = JsonSerializer.Serialize(user);
        File.WriteAllText(""user.json"", json);

        string readJson = File.ReadAllText(""user.json"");
        User deserialized = JsonSerializer.Deserialize<User>(readJson);

        Console.WriteLine($""Name: {deserialized.Name}, Age: {deserialized.Age}, Email: {deserialized.Email}"");
    }
}

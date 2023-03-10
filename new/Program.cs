var people = new string[] { "jgug", "hhhj hhh", "-2" };
string[] group = Array.FindAll(people, person => person.Length <= 3);
foreach (var person in group) Console.WriteLine(person);
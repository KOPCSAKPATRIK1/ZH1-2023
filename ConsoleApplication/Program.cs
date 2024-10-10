using Common;

TrivialPersonSource trivialPersonSource = new TrivialPersonSource(3);
AdvancedPersonSource advancedPersonSource = new AdvancedPersonSource(new List<Person>());
for (int i = 0; i < 4; i++)
{
    advancedPersonSource.Add($"Name{i}", i, i);
}

foreach (Person person in advancedPersonSource.GetPersons())
{
    Console.WriteLine(person.ToString()); 
}

foreach (Person person in trivialPersonSource.GetPersons())
{
    Console.WriteLine(person.ToString());
}
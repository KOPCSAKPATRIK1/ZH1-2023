namespace Common;

public class AdvancedPersonSource : IPersonSource
{
    private List<Person> _persons;

    public AdvancedPersonSource(List<Person> persons)
    {
        _persons = persons;
    }

    public IEnumerable<Person> GetPersons()
    {
       return _persons;
    }

    public void Add(string name, int age, int height)
    {
        _persons.Add(new Person(name, age, height));
    }
}

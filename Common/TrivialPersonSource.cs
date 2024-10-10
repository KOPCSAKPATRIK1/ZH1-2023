namespace Common;

public class TrivialPersonSource : IPersonSource
{
    private int _n;

    public TrivialPersonSource(int n)
    {
        _n = n;
    }

    public IEnumerable<Person> GetPersons()
    {
        List<Person> persons = new List<Person>();
        for (int i = 0; i < _n; i++)
        {
            persons.Add(Person.GetMe());
        }
        return persons;
    }
}

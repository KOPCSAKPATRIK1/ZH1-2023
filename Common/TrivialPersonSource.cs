namespace Common;

public class TrivialPersonSource : IPersonSource
{
    List<Person> _persons = new List<Person>();
    private int _n;

    public TrivialPersonSource(int n)
    {
        _n = n;
    }

    public IEnumerable<Person> GetPersons()
    {
        for (int i = 0; i < _n; i++)
        {
            yield return Person.GetMe();
        }
    }
}

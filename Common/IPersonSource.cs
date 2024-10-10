namespace Common;

public interface IPersonSource
{
    IEnumerable<Person> GetPersons();
}

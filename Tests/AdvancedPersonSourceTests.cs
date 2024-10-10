using Common;

namespace Tests
{
    public class AdvancedPersonSourceTests
    {
        AdvancedPersonSource _personSource = new AdvancedPersonSource(new List<Person>());

        [Fact]
        public void AddThreePersons()
        {
            _personSource.Add("Name1", 1, 1);
            _personSource.Add("Name2", 1, 1);
            _personSource.Add("Name3", 1, 1);

            var persons = _personSource.GetPersons();

            Assert.Equal(3, persons.Count());
        }
    }
}

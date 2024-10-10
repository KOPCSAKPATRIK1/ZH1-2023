using Common;


namespace Tests;

public class TrivialPersonSourceTests
{
    [Fact]
    public void TestCount()
    {
        var persons = new TrivialPersonSource(12).GetPersons();
        Assert.Equal(12, persons.Count());
    }
}

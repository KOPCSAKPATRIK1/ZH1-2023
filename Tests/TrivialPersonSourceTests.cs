using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class TrivialPersonSourceTests
    {
        [Fact]
        public void TestCount()
        {
            var persons = new TrivialPersonSource(12).GetPersons();
            Assert.Equal(12, persons.Count());
        }
    }
}

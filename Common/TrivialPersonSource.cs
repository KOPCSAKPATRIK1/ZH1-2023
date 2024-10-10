using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TrivialPersonSource : IPersonSource
    {
        public int _n;

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
}

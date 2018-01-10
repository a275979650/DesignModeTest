using System.Collections.Generic;

namespace DesignMode.FilterPattern
{
    public class CriteriaSingle:ICriteria
    {
        public List<Person> meetCriteria(List<Person> persons)
        {
            List<Person> singlePersons = new List<Person>();
            foreach (Person person in persons)
            {
                if (person.MaritalStatus.Equals("SINGLE", System.StringComparison.CurrentCultureIgnoreCase))
                {
                    singlePersons.Add(person);
                }
            }
            return singlePersons;
        }
    }
}
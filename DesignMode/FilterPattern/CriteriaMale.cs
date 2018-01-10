using System.Collections.Generic;

namespace DesignMode.FilterPattern
{
    public class CriteriaMale:ICriteria
    {
        public List<Person> meetCriteria(List<Person> persons)
        {
            List<Person> malePersons = new List<Person>();
            foreach (Person person in persons)
            {
                if (person.Gender.Equals("MALE",System.StringComparison.CurrentCultureIgnoreCase))
                {
                    malePersons.Add(person);
                }
            }
            return malePersons;
        }
    }
}
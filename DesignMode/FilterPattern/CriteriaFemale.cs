using System.Collections.Generic;

namespace DesignMode.FilterPattern
{
    public class CriteriaFemale:ICriteria
    {
        public List<Person> meetCriteria(List<Person> persons)
        {
            List<Person> femalePersons = new List<Person>();
            foreach (Person person in persons)
            {
                if (person.Gender.Equals("FEMALE", System.StringComparison.CurrentCultureIgnoreCase))
                {
                    femalePersons.Add(person);
                }
            }
            return femalePersons;
        }
    }
}
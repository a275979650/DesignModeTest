using System.Collections.Generic;

namespace DesignMode.FilterPattern
{
    public interface ICriteria
    {
        List<Person> meetCriteria(List<Person> persons);
    }
}
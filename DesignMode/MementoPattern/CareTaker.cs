using System.Collections.Generic;

namespace DesignMode.MementoPattern
{
    public class CareTaker
    {
        private List<Memento> mementoList = new List<Memento>();

        public void add(Memento state)
        {
            mementoList.Add(state);
        }

        public Memento get(int index)
        {
            return mementoList[index];
        }
    }
}
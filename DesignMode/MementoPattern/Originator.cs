namespace DesignMode.MementoPattern
{
    public class Originator
    {
        private string state;

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public Memento saveStateToMemento()
        {
            return new Memento(state);
        }

        public void getStateFromMemento(Memento Memento)
        {
            state = Memento.State;
        }
    }
}
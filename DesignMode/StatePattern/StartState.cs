namespace DesignMode.StatePattern
{
    public class StartState:IState
    {
        public string doAction(Context context)
        {
            context.setState(this);
            return"Player is in start state";
        }
        public override string ToString()
        {
            return "Start State";
        }
    }
}
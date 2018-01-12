namespace DesignMode.StatePattern
{
    public class StopState:IState
    {
        public string doAction(Context context)
        {   
            context.setState(this);
            return "Player is in stop state";
        }

        public override string ToString()
        {
            return "Stop State";
        }
    }
}
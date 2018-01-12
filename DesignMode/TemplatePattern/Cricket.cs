namespace DesignMode.TemplatePattern
{
    public class Cricket:Game
    {
        public override string initialize()
        {
            return "Cricket Game Initialized! Start playing.\r\n";
        }

        public override string startPlay()
        {
            return "Cricket Game Started. Enjoy the game!\r\n";
        }

        public override string endPlay()
        {
            return "Cricket Game Finished!\r\n";
        }
    }
}
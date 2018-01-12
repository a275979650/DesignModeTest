namespace DesignMode.TemplatePattern
{
    public class Football:Game
    {
        public override string initialize()
        {
            return "Football Game Initialized! Start playing.\r\n";
        }

        public override string startPlay()
        {
            return "Football Game Started. Enjoy the game!\r\n";
        }

        public override string endPlay()
        {
            return "Football Game Finished!\r\n";
        }
    }
}
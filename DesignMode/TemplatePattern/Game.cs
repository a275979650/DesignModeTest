namespace DesignMode.TemplatePattern
{
    public abstract class Game
    {
        public abstract string initialize();
        public abstract string startPlay();
        public abstract string endPlay();

        //模板
        public string play()
        {
            string str = "";
            //初始化游戏
            str+=initialize();

            //开始游戏
            str += startPlay();

            //结束游戏
            str += endPlay();
            return str;
        }
    }
}
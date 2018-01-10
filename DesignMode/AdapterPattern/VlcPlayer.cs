namespace DesignMode.AdapterPattern
{
    public class VlcPlayer:IAdvancedMediaPlayer
    {
        public string playVlc(string fileName)
        {
            return "Playing vlc file. Name: " + fileName;
        }

        public string playMp4(string fileName)
        {
            return "";
        }
    }
}
namespace DesignMode.AdapterPattern
{
    public class Mp4Player:IAdvancedMediaPlayer
    {
        public string playVlc(string fileName)
        {
            return "";
        }

        public string playMp4(string fileName)
        {
            return "Playing mp4 file. Name: " + fileName;
        }
    }
}
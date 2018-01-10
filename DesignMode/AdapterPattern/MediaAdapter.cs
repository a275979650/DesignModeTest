namespace DesignMode.AdapterPattern
{
    public class MediaAdapter:IMediaPlayer
    {
        private IAdvancedMediaPlayer advancedMusicPlayer;

        public MediaAdapter(string audioType)
        {
            if (audioType.Equals("vlc"))
            {
                advancedMusicPlayer = new VlcPlayer();
            }
            else if (audioType.Equals("mp4"))
            {
                advancedMusicPlayer = new Mp4Player();
            }
        }
        public string play(string audioType, string fileName)
        {
            string str = "";
            if (audioType.Equals("vlc"))
            {
                str = advancedMusicPlayer.playVlc(fileName);
            }
            else if (audioType.Equals("mp4"))
            {
                str = advancedMusicPlayer.playMp4(fileName);
            }
            return str;
        }
    }
}
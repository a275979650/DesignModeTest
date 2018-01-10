namespace DesignMode.AdapterPattern
{
    public class AudioPlayer:IMediaPlayer
    {
        private MediaAdapter mediaAdapter;
        public string play(string audioType, string fileName)
        {
            string str = "";
            //播放 mp3 音乐文件的内置支持
            if (audioType.Equals("mp3"))
            {
                str = "Playing mp3 file. Name: " + fileName;
            }
            //mediaAdapter 提供了播放其他文件格式的支持
            else if (audioType.Equals("vlc")
                     || audioType.Equals("mp4"))
            {
                mediaAdapter = new MediaAdapter(audioType);
                str = mediaAdapter.play(audioType, fileName);
            }
            else
            {
                str = "Invalid media. " +
                                   audioType + " format not supported";
            }
            return str;
        }
    }
}
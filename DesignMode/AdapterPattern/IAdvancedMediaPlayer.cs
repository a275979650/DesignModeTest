namespace DesignMode.AdapterPattern
{
    public interface IAdvancedMediaPlayer
    {
        string playVlc(string fileName);
        string playMp4(string fileName);
    }
}
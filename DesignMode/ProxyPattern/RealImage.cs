namespace DesignMode.ProxyPattern
{
    public class RealImage:IImage
    {
        private string fileName;

        public RealImage(string fileName,ref string str)
        {
            this.fileName = fileName;
            str = loadFromDisk(fileName);
        }
        public string display()
        {
           return "Displaying " + fileName;
        }

        private string loadFromDisk(string fileName)
        {
            return "Loading " + fileName;
        }
    }
}
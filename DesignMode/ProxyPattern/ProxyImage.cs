using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode.ProxyPattern
{
    public class ProxyImage:IImage
    {
        private RealImage realImage;
        private string fileName;

        public ProxyImage(String fileName)
        {
            this.fileName = fileName;
        }
        public string display()
        {
            string str = "";
            if (realImage == null)
            {
                realImage = new RealImage(fileName, ref str);
            }
            str = !string.IsNullOrEmpty(str) ? str + "\r\n" + realImage.display() : realImage.display();
            return str;
        }
    }
}

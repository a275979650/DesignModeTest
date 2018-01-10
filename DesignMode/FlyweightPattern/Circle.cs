namespace DesignMode.FlyweightPattern
{
    public class Circle:IShape
    {
        private string color;
        private int x;
        private int y;
        private int radius;

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public int Radius
        {
            get
            {
                return radius;
            }

            set
            {
                radius = value;
            }
        }

        public Circle(string color)
        {
            this.color = color;
        }

        public string draw()
        {
            return "Circle: Draw() [Color : " + color
                               + ", x : " + X + ", y :" + Y + ", radius :" + Radius+"\r\n";
        }
    }
}
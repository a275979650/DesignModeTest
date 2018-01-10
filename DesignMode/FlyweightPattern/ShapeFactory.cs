using System.Collections.Generic;

namespace DesignMode.FlyweightPattern
{
    public class ShapeFactory
    {
        private static readonly Dictionary<string,IShape> circleMap = new Dictionary<string, IShape>();

        public static IShape getCircle(string color,ref string returnStr)
        {
            Circle circle = null;
            if (circleMap.ContainsKey(color))
            {
                circle = (Circle) circleMap[color];
            }
            else
            {
                circle = new Circle(color);
                circleMap.Add(color, circle);
                returnStr = "Creating circle of color :" + color + "\r\n";
            }
            return circle;
        }
    }
}
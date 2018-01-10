namespace DesignMode.BridgePattern
{
    public class RedCircle:IDrawAPI
    {
        public string drawCircle(int radius, int x, int y)
        {
            return "Drawing Circle[ color: red, radius: "
                   + radius + ", x: " + x + ", " + y + "]";
        }
    }
}
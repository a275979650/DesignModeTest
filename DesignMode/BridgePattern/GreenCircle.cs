namespace DesignMode.BridgePattern
{
    public class GreenCircle:IDrawAPI
    {
        public string drawCircle(int radius, int x, int y)
        {
            return "Drawing Circle[ color: green, radius: "
                   + radius + ", x: " + x + ", " + y + "]";
        }
    }
}
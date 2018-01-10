namespace DesignMode.BridgePattern
{
    public class BlueCircle:IDrawAPI
    {
        public string drawCircle(int radius, int x, int y)
        {
            return "Drawing Circle[ color: blue, radius: "
                   + radius + ", x: " + x + ", " + y + "]";
        }
    }
}
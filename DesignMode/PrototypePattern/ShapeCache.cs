using System;
using System.Collections;
using System.Collections.Generic;
namespace DesignMode.PrototypePattern
{
    public class ShapeCache
    {
        private static Hashtable shapeMap =  new Hashtable();

        public static Shape getShape(string shapeId)
        {
            Shape cachedShape = shapeMap[shapeId] as Shape;
            return (Shape)cachedShape.clone();
        }

        // 对每种形状都运行数据库查询，并创建该形状
        // shapeMap.put(shapeKey, shape);
        // 例如，我们要添加三种形状
        public static void loadCache()
        {
            Circle circle = new Circle();
            circle.Id = "1";
            shapeMap.Add(circle.Id, circle);

            Square square = new Square();
            square.Id="2";
            shapeMap.Add(square.Id, square);

            Rectangle rectangle = new Rectangle();
            rectangle.Id="3";
            shapeMap.Add(rectangle.Id, rectangle);
        }
    }
}
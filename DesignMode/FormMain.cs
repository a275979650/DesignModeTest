﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesignMode.AdapterPattern;
using DesignMode.BridgePattern;
using DesignMode.BuilderPattern;
using DesignMode.FilterPattern;
using DesignMode.PrototypePattern;
using DesignMode.SingletonPattern;
using Shape = DesignMode.PrototypePattern.Shape;

namespace DesignMode
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btFactory_Click(object sender, EventArgs e)
        {
            string outStr = "";
            ShapeFactory shapeFactory = new ShapeFactory();
            IShape shape1 = shapeFactory.getShape("CIRCLE");
            outStr += shape1.draw();
            IShape shape2 = shapeFactory.getShape("RECTANGLE");
            outStr += shape2.draw();
            IShape shape3 = shapeFactory.getShape("SQUARE");
            outStr += shape3.draw();
            tbOutWindow.Text = outStr;
        }

        private void btAbstractFactory_Click(object sender, EventArgs e)
        {
            string str = "";
            //获取形状工厂
            IAbstractFactory shapeFactory = FactoryProducer.getFactory("SHAPE");
            //获取形状为 Circle 的对象
            IShape shape1 = shapeFactory.getShape("CIRCLE");

            //调用 Circle 的 draw 方法
            str +=shape1.draw();

            //获取形状为 Rectangle 的对象
            IShape shape2 = shapeFactory.getShape("RECTANGLE");

            //调用 Rectangle 的 draw 方法
            str += shape2.draw();

            //获取形状为 Square 的对象
            IShape shape3 = shapeFactory.getShape("SQUARE");

            //调用 Square 的 draw 方法
            str += shape3.draw();

            //获取颜色工厂
            IAbstractFactory colorFactory = FactoryProducer.getFactory("COLOR");

            //获取颜色为 Red 的对象
            IColor color1 = colorFactory.getColor("RED");

            //调用 Red 的 fill 方法
            str += color1.Fill();

            //获取颜色为 Green 的对象
            IColor color2 = colorFactory.getColor("GREEN");

            //调用 Green 的 fill 方法
            str += color2.Fill();

            //获取颜色为 Blue 的对象
            IColor color3 = colorFactory.getColor("BLUE");

            //调用 Blue 的 fill 方法
            str += color3.Fill();
            tbOutWindow.Text = str;
        }

        private void btSingletonPattern_Click(object sender, EventArgs e)
        {
            string str = "";
            //不合法的构造函数
            //编译时错误：构造函数 SingleObject() 是不可见的
            //SingleObject object = new SingleObject();

            //获取唯一可用的对象
            SingleObject o = SingleObject.getInstance();

            //显示消息
            str = o.showMessage();
            tbOutWindow.Text = str;
        }

        private void btBuilderPattern_Click(object sender, EventArgs e)
        {
            string str = "";
            MealBuilder mealBuilder = new MealBuilder();

            Meal vegMeal = mealBuilder.prepareVegMeal();
            str+="Veg Meal\r\n";
            str+=vegMeal.showItems();
            str += "Total Cost: " + vegMeal.getCost()+"\r\n";

            Meal nonVegMeal = mealBuilder.prepareNonVegMeal();
            str += "\n\nNon-Veg Meal\r\n";
            str+=nonVegMeal.showItems();
            str += "Total Cost: " + nonVegMeal.getCost()+"\r\n";
            tbOutWindow.Text = str;
        }

        private void btPrototypePattern_Click(object sender, EventArgs e)
        {
            string str = "";
            ShapeCache.loadCache();

            Shape clonedShape = (Shape)ShapeCache.getShape("1");
            str += "Shape : " + clonedShape.Type + "\r\n";

            Shape clonedShape2 = (Shape)ShapeCache.getShape("2");
            str += "Shape : " + clonedShape2.Type + "\r\n";

            Shape clonedShape3 = (Shape)ShapeCache.getShape("3");
            str += "Shape : " + clonedShape3.Type + "\r\n";
            tbOutWindow.Text = str;
        }

        private void btAdapterPattern_Click(object sender, EventArgs e)
        {
            string str = "";
            AudioPlayer audioPlayer = new AudioPlayer();

            str += audioPlayer.play("mp3", "beyond the horizon.mp3")+"\r\n";
            str += audioPlayer.play("mp4", "alone.mp4") + "\r\n";
            str += audioPlayer.play("vlc", "far far away.vlc") + "\r\n";
            str += audioPlayer.play("avi", "mind me.avi") + "\r\n";
            tbOutWindow.Text = str;
        }

        private void btBridgePattern_Click(object sender, EventArgs e)
        {
            string str = "";
            BridgePattern.Shape redCircle = new BridgePattern.Circle(100, 100, 10, new RedCircle());
            BridgePattern.Shape greenCircle = new BridgePattern.Circle(100, 100, 10, new GreenCircle());
            BridgePattern.Shape blueCircle = new BridgePattern.Circle(110, 110, 10, new BlueCircle());
            str += redCircle.draw() + "\r\n";
            str += greenCircle.draw() + "\r\n";
            str += blueCircle.draw() + "\r\n";
            tbOutWindow.Text = str;
        }

        private void btFilterPattern_Click(object sender, EventArgs e)
        {
            string str = "";
            List<Person> persons = new List<Person>();

            persons.Add(new Person("Robert", "Male", "Single"));
            persons.Add(new Person("John", "Male", "Married"));
            persons.Add(new Person("Laura", "Female", "Married"));
            persons.Add(new Person("Diana", "Female", "Single"));
            persons.Add(new Person("Mike", "Male", "Single"));
            persons.Add(new Person("Bobby", "Male", "Single"));

            ICriteria male = new CriteriaMale();
            ICriteria female = new CriteriaFemale();
            ICriteria single = new CriteriaSingle();
            ICriteria singleMale = new AndCriteria(single, male);
            ICriteria singleOrFemale = new OrCriteria(single, female);

            str += "Males:\r\n ";
            str += printPersons(male.meetCriteria(persons)) + "\r\n";

            str += "Females:\r\n ";
            str += printPersons(female.meetCriteria(persons)) + "\r\n";

            str += "Single Males:\r\n ";
            str += printPersons(singleMale.meetCriteria(persons)) + "\r\n";

            str += "Single Or Females:\r\n ";
            str += printPersons(singleOrFemale.meetCriteria(persons)) + "\r\n";
            tbOutWindow.Text = str;
        }

        public static string printPersons(List<Person> persons)
        {
            string str = "";
            foreach (Person person in persons)
            {
                str+="Person : [ Name : " + person.Name
                                   + ", Gender : " + person.Gender
                                   + ", Marital Status : " + person.MaritalStatus
                                   + " ]" +"\r\n";
            }
            return str;
        }
    }
}

using System;
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
using DesignMode.ChainofResponsibilityPattern;
using DesignMode.CommandPattern;
using DesignMode.CompositePattern;
using DesignMode.DecoratorPattern;
using DesignMode.FacadePattern;
using DesignMode.FilterPattern;
using DesignMode.InterpreterPattern;
using DesignMode.IteratorPattern;
using DesignMode.MediatorPattern;
using DesignMode.MementoPattern;
using DesignMode.NullObjectPattern;
using DesignMode.ObserverPattern;
using DesignMode.PrototypePattern;
using DesignMode.ProxyPattern;
using DesignMode.SingletonPattern;
using DesignMode.StatePattern;
using DesignMode.StrategyPattern;
using DesignMode.TemplatePattern;
using Context = DesignMode.StatePattern.Context;

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

            PrototypePattern.Shape clonedShape = (PrototypePattern.Shape)ShapeCache.getShape("1");
            str += "Shape : " + clonedShape.Type + "\r\n";

            PrototypePattern.Shape clonedShape2 = (PrototypePattern.Shape)ShapeCache.getShape("2");
            str += "Shape : " + clonedShape2.Type + "\r\n";

            PrototypePattern.Shape clonedShape3 = (PrototypePattern.Shape)ShapeCache.getShape("3");
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

        private void btCompositePattern_Click(object sender, EventArgs e)
        {
            string str = "";
            Employee CEO = new Employee("John", "CEO", 30000);

            Employee headSales = new Employee("Robert", "Head Sales", 20000);

            Employee headMarketing = new Employee("Michel", "Head Marketing", 20000);

            Employee clerk1 = new Employee("Laura", "Marketing", 10000);
            Employee clerk2 = new Employee("Bob", "Marketing", 10000);

            Employee salesExecutive1 = new Employee("Richard", "Sales", 10000);
            Employee salesExecutive2 = new Employee("Rob", "Sales", 10000);

            CEO.add(headSales);
            CEO.add(headMarketing);

            headSales.add(salesExecutive1);
            headSales.add(salesExecutive2);

            headMarketing.add(clerk1);
            headMarketing.add(clerk2);

            //打印该组织的所有员工
            str += CEO +"\r\n";
            foreach (Employee headEmployee in CEO.getSubordinates())
            {
                str += headEmployee + "\r\n";
                foreach (Employee employee in headEmployee.getSubordinates())
                {
                    str += employee + "\r\n";
                }
            }
            tbOutWindow.Text = str;
        }

        private void btDecoratorPattern_Click(object sender, EventArgs e)
        {
            string str = "";
            DesignMode.DecoratorPattern.IShape circle = new DecoratorPattern.Circle();

            DesignMode.DecoratorPattern.IShape redCircle = new DecoratorPattern.RedShapeDecorator(new DecoratorPattern.Circle());

            DecoratorPattern.IShape redRectangle = new DesignMode.DecoratorPattern.RedShapeDecorator(new DecoratorPattern.Rectangle());
            str += "Circle with normal border" + "\r\n";
            str += circle.draw() + "\r\n";

            str += "Circle of red border" + "\r\n";
            str += redCircle.draw() + "\r\n";

            str += "Rectangle of red border" + "\r\n";
            str += redRectangle.draw() + "\r\n";
            tbOutWindow.Text = str;
        }

        private void btFacadePattern_Click(object sender, EventArgs e)
        {
            string str = "";
            ShapeMaker shapeMaker = new ShapeMaker();

            str += shapeMaker.drawCircle() + "\r\n";
            str += shapeMaker.drawRectangle() + "\r\n";
            str += shapeMaker.drawSquare() + "\r\n";
            tbOutWindow.Text = str;
        }
        /// <summary>
        /// 用于享元模式，放靠近点，实际应用按规范编写
        /// </summary>
        private static readonly string[] colors = { "Red", "Green", "Blue", "White", "Black" };
        private void btFlyweightPattern_Click(object sender, EventArgs e)
        {
            string str = "";
            string s = "";
            for (int i = 0; i < 20; ++i)
            {
                FlyweightPattern.Circle circle =
                    (FlyweightPattern.Circle)FlyweightPattern.ShapeFactory.getCircle(getRandomColor(), ref s);
                circle.X = getRandomX();
                circle.Y = getRandomY();
                circle.Radius = 100;
                str+=s+"\r\n"+circle.draw();
            }
            tbOutWindow.Text = str;

        }
        private static string getRandomColor()
        {
            int i = new Random().Next(colors.Length);
            return colors[i];
        }
        private static int getRandomX()
        {
            return (int)(new Random().Next(0, 5) * 100);
        }
        private static int getRandomY()
        {
            return (int)(new Random().Next(0, 5) * 100);
        }

        private void btProxyPattern_Click(object sender, EventArgs e)
        {
            string str = "";
            IImage image = new ProxyImage("test_10mb.jpg");

            //图像将从磁盘加载
            str += image.display()+"\r\n";
            //图像将无法从磁盘加载
            str += image.display()+"\r\n";
            tbOutWindow.Text = str;
        }

        private void btChainofResponsibilityPattern_Click(object sender, EventArgs e)
        {
            string str = "";
            AbstractLogger loggerChain = getChainOfLoggers();

            str+=loggerChain.logMessage(AbstractLogger.INFO,
                "This is an information.");

            str += loggerChain.logMessage(AbstractLogger.DEBUG,
                "This is an debug level information.");

            str += loggerChain.logMessage(AbstractLogger.ERROR,
                "This is an error information.");
            tbOutWindow.Text = str;
        }

        private static AbstractLogger getChainOfLoggers()
        {

            AbstractLogger errorLogger = new ErrorLogger(AbstractLogger.ERROR);
            AbstractLogger fileLogger = new FileLogger(AbstractLogger.DEBUG);
            AbstractLogger consoleLogger = new ConsoleLogger(AbstractLogger.INFO);

            errorLogger.setNextLogger(fileLogger);
            fileLogger.setNextLogger(consoleLogger);

            return errorLogger;
        }

        private void btCommandPattern_Click(object sender, EventArgs e)
        {
            Stock abcStock = new Stock();

            BuyStock buyStockOrder = new BuyStock(abcStock);
            SellStock sellStockOrder = new SellStock(abcStock);

            Broker broker = new Broker();
            broker.takeOrder(buyStockOrder);
            broker.takeOrder(sellStockOrder);

            tbOutWindow.Text =  broker.placeOrders();
        }
        //规则：Robert 和 John 是男性
        public static IExpression getMaleExpression()
        {
            IExpression robert = new TerminalExpression("Robert");
            IExpression john = new TerminalExpression("John");
            return new OrExpression(robert, john);
        }

        //规则：Julie 是一个已婚的女性
        public static IExpression getMarriedWomanExpression()
        {
            IExpression julie = new TerminalExpression("Julie");
            IExpression married = new TerminalExpression("Married");
            return new AndExpression(julie, married);
        }
        private void btInterpreterPattern_Click(object sender, EventArgs e)
        {
            string str = "";
            IExpression isMale = getMaleExpression();
            IExpression isMarriedWoman = getMarriedWomanExpression();

            str += "John is male? " + isMale.interpret("John")+"\r\n";
            str += "Julie is a married women? "
                               + isMarriedWoman.interpret("Married Julie")+"\r\n";
            tbOutWindow.Text = str;
        }

        private void btIteratorPattern_Click(object sender, EventArgs e)
        {
            string str = "";
            NameRepository namesRepository = new NameRepository();

            for (IIterator iter = namesRepository.getIterator(); iter.hasNext();)
            {
                String name = (String)iter.next();
                str+="Name : " + name+"\r\n";
            }
            tbOutWindow.Text = str;
        }

        private void btMediatorPattern_Click(object sender, EventArgs e)
        {
            string str = "";
            User robert = new User("Robert");
            User john = new User("John");

            str+=robert.sendMessage("Hi! John!")+"\r\n";
            str+=john.sendMessage("Hello! Robert!")+"\r\n";
            tbOutWindow.Text = str;
        }

        private void btMementoPattern_Click(object sender, EventArgs e)
        {
            string str = "";
            Originator originator = new Originator();
            CareTaker careTaker = new CareTaker();
            originator.State="State #1";
            originator.State="State #2";
            careTaker.add(originator.saveStateToMemento());
            originator.State="State #3";
            careTaker.add(originator.saveStateToMemento());
            originator.State="State #4";

            str+="Current State: " + originator.State + "\r\n";
            originator.getStateFromMemento(careTaker.get(0));
            str += "First saved State: " + originator.State + "\r\n";
            originator.getStateFromMemento(careTaker.get(1));
            str += "Second saved State: " + originator.State + "\r\n";
            tbOutWindow.Text = str;
        }

        private void btObserverPattern_Click(object sender, EventArgs e)
        {
            Subject subject = new Subject();

            new HexaObserver(subject);
            new OctalObserver(subject);
            new BinaryObserver(subject);

            string str="";
            str += "First state change: 15\r\n";
            str += subject.setState(15);
            str += "Second state change: 10\r\n";
            str += subject.setState(10);
            tbOutWindow.Text = str;
        }

        private void btStatePattern_Click(object sender, EventArgs e)
        {
            string str = "";
            Context context = new Context();

            StartState startState = new StartState();
            str+=startState.doAction(context)+"\r\n";

            str+=context.getState().ToString() + "\r\n";

            StopState stopState = new StopState();
            str += stopState.doAction(context) + "\r\n";

            str += context.getState().ToString() + "\r\n";
            tbOutWindow.Text = str;
        }

        private void btNullObjectPattern_Click(object sender, EventArgs e)
        {
            string str = "";
            AbstractCustomer customer1 = CustomerFactory.getCustomer("Rob");
            AbstractCustomer customer2 = CustomerFactory.getCustomer("Bob");
            AbstractCustomer customer3 = CustomerFactory.getCustomer("Julie");
            AbstractCustomer customer4 = CustomerFactory.getCustomer("Laura");

            str += "Customers";
            str += customer1.getName() + "\r\n";
            str += customer2.getName() + "\r\n";
            str += customer3.getName() + "\r\n";
            str += customer4.getName() + "\r\n";
            tbOutWindow.Text = str;
        }

        private void btStrategyPattern_Click(object sender, EventArgs e)
        {
            string str = "";
            StrategyPattern.Context context = new StrategyPattern.Context(new OperationAdd());
            str +="10 + 5 = " + context.executeStrategy(10, 5)+"\r\n";

            context = new StrategyPattern.Context(new OperationSubstract());
            str += "10 - 5 = " + context.executeStrategy(10, 5)+"\r\n";

            context = new StrategyPattern.Context(new OperationMultiply());
            str += "10 * 5 = " + context.executeStrategy(10, 5)+"\r\n";
            tbOutWindow.Text = str;
        }

        private void btTemplatePattern_Click(object sender, EventArgs e)
        {
            string str = "";
            Game game = new Cricket();
            str+=game.play();
            game = new Football();
            str+=game.play();
            tbOutWindow.Text = str;
        }
    }
}

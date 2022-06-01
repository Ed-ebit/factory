// See https://aka.ms/new-console-template for more information


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is an awesome program to learn about creational patterns \n"
        + "which one shall be executed? \n1.The abstract factory \n2.the factory \n3.Builder\n"
        + "4.Prototype \n5.Singleton\nInsert corresponding number and press Enter");
        String selection = Console.ReadLine();
        if (selection == "2")
        {
            Console.WriteLine("please enter \n'triangle', \n'rectangle', \nor 'circle'");
            selection = Console.ReadLine();
            ShapeFactory2D shape = new ShapeFactory2D();
            var chosenShape = shape.get2DShape(selection);
            if (chosenShape != null)
            {
                chosenShape.draw();
            }
        }
        else System.Console.WriteLine("nothing here yet");
    }
}


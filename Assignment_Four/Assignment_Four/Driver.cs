using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Four
{
    public class Driver
    {
        static List<Shape> shapes = new List<Shape>();
        public static void Main(string[] args)
        {
            //  Question 1/2
            /*Rectangle rec = new Rectangle(7, 8);
            Console.WriteLine(rec.ToString());
            Console.WriteLine("The perimeter of the rectangle is:");
            Console.WriteLine(rec.GetPerimeter());
            Console.WriteLine("The area of the rectangle is:");
            Console.WriteLine(rec.GetArea());
            Circle cir = new Circle(8);
            Console.WriteLine(cir.ToString());
            Console.WriteLine("The perimeter of the circle is:");
            Console.WriteLine(cir.GetPerimeter());
            Console.WriteLine("The area of the circle is:");
            Console.WriteLine(cir.GetArea());

            Console.WriteLine("\nParsing:");
            Rectangle recParse = MyExtension.Rec_Parse("Rectangle,2,3.5");
            Circle cirParse = MyExtension.Circ_Parse("Circle,1");

            MyExtension.Print(recParse);
            MyExtension.Print(cirParse);*/



            //  Question 3
            TextFileProcessor.Read(@"C:\Users\liamd\source\repos\Assignment_Four\Assignment_Four\TextFile1.txt");
            Console.ReadLine();


            //  Question 4
            TextFileProcessor.LineRead += EachLine;

            TextFileProcessor.Read(@"C:\Users\liamd\source\repos\Assignment_Four\Assignment_Four\ShapeList.txt");

            // linq fun startin'
            // Sorting per name and area
            var NameAreaSort =
                from shape in shapes
                orderby shape.GetType().Name, shape.GetArea()
                select shape;
            //print
            Console.Write("Name and area sort:");
            foreach (var x in NameAreaSort)
                Console.WriteLine($"{x.Name},{x.GetArea()}");

            //Linq sorting per perimeter
            var PerimeterSort =
                from shape in shapes
                orderby shape.GetPerimeter()
                select shape;
            // print
            Console.Write("Name and Perimeter sort:");
            foreach (var x in PerimeterSort)
                Console.WriteLine($"{x.Name},{x.GetPerimeter()}");

            //Statistics for each type of shape
            var perShape =
                      from shape in shapes
                      group shape by shape.Name into shapeGroup
                      orderby shapeGroup.Key
                      select shapeGroup;

            //Do this for both shape
            perShape.ToList().ForEach(one =>
            {
                int i = 0;
                foreach (var shape in one)
                {
                    i++;
                }

                double averageAreaEach = (one.Sum(s => s.GetArea())) / (i);
                Console.WriteLine("Average area for " + one.Key + ": " + averageAreaEach);

                double averagePeriEach = (one.Sum(s => s.GetPerimeter())) / (i);
                Console.WriteLine("Average perimeter for " + one.Key + ": " + averagePeriEach);
            });
            // Final step
            double averageArea = (shapes.Sum(x => x.GetArea()) / shapes.Count);
            double averagePeri = (shapes.Sum(x => x.GetPerimeter()) / shapes.Count);

            Console.WriteLine("\n\nAverage perimeter: " + averagePeri);
            Console.WriteLine("Average area: " + averageArea);
            Console.WriteLine("Total of shapes: " + shapes.Count);
             

            Console.ReadLine();
        }
        public static void EachLine(Object o, string input)
        {
            string[] shapeName = input.Split(',');

            // call correct parse method based on first element on line
            if (shapeName[0] == "Circle")
                shapes.Add(MyExtension.Circ_Parse(input));
            else if (shapeName[0] == "Rectangle")
                shapes.Add(MyExtension.Rec_Parse(input));
        }
    }
}

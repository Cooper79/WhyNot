using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_9
{
    class Program
    {
        enum Colors
        {
            White = 0,
            Black,
            Blue,
            Orange,
            Red,
            Green
        }
        public abstract class Shape : IDraw
        {
            public double Area;
            public double Perimeter;
            public string Name { get; }
            public ConsoleColor Color { get; set; }
            public double Length { get; set; }
            public abstract double area();
            public abstract double perimeter();
            public abstract void Draw();

            public Shape(string name)
            {
                Random rand = new Random();
                this.Name = name;
                this.Length = rand.Next(0, 100);
                int temp = rand.Next(0, 6);
                var color = Enum.Parse(typeof(ConsoleColor), ((Colors)temp).ToString());
                this.Color = (ConsoleColor)color;

                Area = area();
                Perimeter = perimeter();
            }
            public Shape(string name, double len)
            {
                Random rand = new Random();
                this.Name = name;
                this.Length = len;
                int temp = rand.Next(0, 6);
                var color = Enum.Parse(typeof(ConsoleColor), ((Colors)temp).ToString());
                this.Color = (ConsoleColor)color;

                Area = area();
                Perimeter = perimeter();
            }
            public Shape(string name, double len, string _color)
            {
                Random rand = new Random();
                this.Name = name;
                this.Length = len;
                var color = Enum.Parse(typeof(ConsoleColor), _color);
                this.Color = (ConsoleColor)color;

                Area = area();
                Perimeter = perimeter();
            }
        }

        public class Square : Shape
        {
            public Square(string name) : base(name) { }
            public Square(string name, double len) : base(name, len) { }
            public Square(string name, double len, string color) : base(name, len, color) { }
            public override double area()
            {
                Area = Length * Length;
                return Area;
            }

            public override void Draw()
            {
                Console.BackgroundColor = Color;
                Console.WriteLine(Name);
                Console.WriteLine(Length);
                Console.WriteLine(Area);
                Console.WriteLine(Perimeter);
            }

            public override double perimeter()
            {
                Perimeter = 4 * Length;
                return Perimeter;
            }
        }

        class Circle : Shape
        {
            public Circle(string name) : base(name) { }
            public Circle(string name, double len) : base(name, len) { }
            public Circle(string name, double len, string color) : base(name, len, color) { }
            public override double area()
            {
                Area = Length * Length * Math.Sqrt(3) / 4;
                return Area;
            }
            public override double perimeter()
            {
                Perimeter = 3 * Length;
                return Perimeter;
            }
            public override void Draw()
            {
                Console.BackgroundColor = Color;
                Console.WriteLine(Name);
                Console.WriteLine(Length);
                Console.WriteLine(Area);
                Console.WriteLine(Perimeter);
            }
        }

        class Triangle : Shape
        {
            public Triangle(string name) : base(name) { }
            public Triangle(string name, double len) : base(name, len) { }
            public Triangle(string name, double len, string color) : base(name, len, color) { }
            public override double area()
            {
                Area = Length * Length * Math.Sqrt(3) / 4;
                return Area;
            }
            public override double perimeter()
            {
                Perimeter = 3 * Length;
                return Perimeter;
            }
            public override void Draw()
            {
                Console.BackgroundColor = Color;
                Console.WriteLine(Name);
                Console.WriteLine(Length);
                Console.WriteLine(Area);
                Console.WriteLine(Perimeter);
            }
        }

        class Picture : IDraw
        {
            List<Shape> shapes;
            int amount { get; set; }

            public Picture()
            {
                shapes = new List<Shape>(0);
            }
            public Picture(int n)
            {
                shapes = new List<Shape>(n);
            }

            public Shape this[int index]
            {
                get
                {
                    if (index >= 0 && index < shapes.Count)
                        return shapes[index];
                    else
                    {
                        Console.WriteLine("Попытка обращения за пределы массива.");
                        return null;
                    }
                }
            }

            public void AddShape(Shape shape)
            {
                shapes.Add(shape);
            }

            public void DeleteByName(string name)
            {
                shapes.Remove(shapes.Find(x => x.Name == name));
            }

            public void DeleteByType(string type)
            {
                type = "Laba 9." + type;
                shapes.Remove(shapes.Find(x => x.GetType().ToString() == type));
            }

            public void DeleteByLength(string type)
            {
                shapes.RemoveAll(x => x.Area > 100);
            }
            void IDraw.Draw()
            {
                for (int i = 0; i < shapes.Count; i++)
                {
                    shapes[i].Draw();
                }
            }
        }

        interface IDraw
        {
            void Draw();
        }

        class Painter
        {
            public void DrawShape(IDraw shape)
            {
                shape.Draw();
            }
            public void DrawShapes(List<IDraw> shapes)
            {
                foreach (Shape shape in shapes)
                {
                    shape.Draw();
                }
            }
        }
        static void Main(string[] args)
        {
            Square s = new Square("Квадрат");
            Console.WriteLine($"Периметр {s.Name}а = {s.Perimeter}");
            Console.WriteLine($"Площадь {s.Name}а = {s.Area}");
            Console.WriteLine($"Цвет {s.Name}а = {s.Color}");
            Console.WriteLine();

            Picture picture = new Picture();
            picture.AddShape(s);
            picture.DeleteByType("Square");

            Console.ReadLine();
        }
    }

}

using System;

namespace Math_Figures_Kryukova_OD
{
    class Program
    {
        abstract class Figure
        {
            private string name;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public abstract double GetPerimeter();
            public abstract double GetSquare();
        }
        abstract class VolumeFigure
        {
            private string name;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public abstract double GetSquare();
            public abstract double GetVolume();
        }
        static void Main(string[] args)
        {
            Figure refMF;
            VolumeFigure refMVF;

            Square sqr = new Square("Square", 3);
            refMF = sqr;
            refMF.GetPerimeter();
            refMF.GetSquare();

            Rectangle rctngl = new Rectangle("Rectangle", 5, 6);
            refMF = rctngl;
            refMF.GetPerimeter();
            refMF.GetSquare();

            Triangle trnl = new Triangle("Triangle num_1", 6, 30, 9);
            refMF = trnl;
            refMF.GetPerimeter();
            refMF.GetSquare();

            Triangle trnl_2 = new Triangle("Triangle num_2", 6, 10, 8);
            refMF = trnl_2;
            refMF.GetPerimeter();
            refMF.GetSquare();

            Romb rmb = new Romb("Romb", 4, 8, 11);
            refMF = rmb;
            refMF.GetPerimeter();
            refMF.GetSquare();

            Circle crcl = new Circle("Circle", 8);
            refMF = crcl;
            refMF.GetPerimeter();
            refMF.GetSquare();

            Cylinder clnr = new Cylinder("Cylinder", 3, 6);
            refMVF = clnr;
            refMVF.GetSquare();
            refMVF.GetVolume();

            Sphere sph = new Sphere("Sphere", 5);
            refMVF = sph;
            refMVF.GetSquare();
            refMVF.GetVolume();

            Cube cb = new Cube("Cube", 8);
            refMVF = cb;
            refMVF.GetSquare();
            refMVF.GetVolume();

            Cone cn = new Cone("Cone", 4, 6, 5);
            refMVF = cn;
            refMVF.GetSquare();
            refMVF.GetVolume();
        }

        class Square : Figure
        {
            private double l;
            private string name;

            public Square(string name, double l)
            {
                this.l = l;
                this.name = name;
            }

            public override double GetPerimeter()
            {
                double p = l * 4;
                Console.WriteLine(" ");
                Console.WriteLine("Perimeter of {0} = {1}", name, p);
                return p;
            }
            public override double GetSquare()
            {
                double s = Math.Pow(l, 2);
                Console.WriteLine(" ");
                Console.WriteLine("Square of {0} = {1}", name, s);
                Console.WriteLine("___________________________");
                return s;
            }

        }

        class Rectangle : Figure
        {
            private double a, b;
            private string name;

            public Rectangle(string name, double a, double b)
            {
                this.a = a;
                this.b = b;
                this.name = name;
            }

            public override double GetPerimeter()
            {
                double p = (a + b) * 2;
                Console.WriteLine(" ");
                Console.WriteLine("Perimeter of {0} = {1}", name, p);
                return p;
            }
            public override double GetSquare()
            {
                double s = a * b;
                Console.WriteLine(" ");
                Console.WriteLine("Square of {0} = {1}", name, s);
                Console.WriteLine("___________________________");
                return s;
            }

        }

        class Triangle : Figure
        {
            private double a, b, c;
            private string name;

            public Triangle(string name, double a, double b, double c)
            {
                if (((b + c) > a) && ((a + b) > c) && ((a + c) > b))
                {
                    this.a = a;
                    this.b = b;
                    this.c = c;
                    this.name = name;
                }
                else
                {
                    Console.WriteLine("Can't use such parameters for the sides of a triangle");
                    this.a = this.b = this.c = 3;
                    this.name = "Perfect triangle (as i think)";
                }
            }
            public override double GetPerimeter()
            {
                double p = a + b + c;
                Console.WriteLine(" ");
                Console.WriteLine("Perimeter of {0} = {1}", name, p);
                return p;
            }
            public override double GetSquare()
            {
                double halfPerim = (a + b + c) / 2;
                double s = Math.Sqrt(halfPerim * (halfPerim - a) * (halfPerim - b) * (halfPerim - c));
                Console.WriteLine(" ");
                Console.WriteLine("Square of {0} = {1}", name, s);
                Console.WriteLine("___________________________");
                return s;
            }
        }

        class Romb : Figure
        {
            private double a, d_1, d_2;
            private string name;
            public Romb(string name, double a, double d_1, double d_2)
            {
                this.a = a;
                this.d_1 = d_1;
                this.d_2 = d_2;
                this.name = name;
            }

            public override double GetPerimeter()
            {
                double p = a * 4;
                Console.WriteLine(" ");
                Console.WriteLine("Perimeter of {0} = {1}", name, p);
                return p;
            }
            public override double GetSquare()
            {
                double s = 0.5 * d_1 * d_2;
                Console.WriteLine(" ");
                Console.WriteLine("Square of {0} = {1}", name, s);
                Console.WriteLine("___________________________");
                return s;
            }

        }

        class Circle : Figure
        {
            private double r;
            private string name;
            public Circle(string name, double r)
            {
                this.r = r;
                this.name = name;
            }

            public override double GetPerimeter()
            {
                double p = Math.PI * 2 * r;
                Console.WriteLine(" ");
                Console.WriteLine("Circumference of {0} = {1}", name, p);
                return p;
            }
            public override double GetSquare()
            {
                double s = Math.PI * r * r;
                Console.WriteLine(" ");
                Console.WriteLine("Square of {0} = {1}", name, s);
                Console.WriteLine("___________________________");
                return s;
            }

        }

        class Cylinder : VolumeFigure
        {
            private double r, h;
            private string name;

            public Cylinder(string name, double r, double h)
            {
                this.r = r;
                this.h = h;
                this.name = name;
            }

            public override double GetSquare()
            {
                double s = Math.PI * 2 * r * (h + r);
                Console.WriteLine(" ");
                Console.WriteLine("Full Square of {0} = {1}", name, s);
                return s;
            }
            public override double GetVolume()
            {
                double v = Math.PI * r * r * h;
                Console.WriteLine(" ");
                Console.WriteLine("Volume of {0} = {1}", name, v);
                Console.WriteLine("___________________________");
                return v;
            }

        }

        class Sphere : VolumeFigure
        {
            private double r;
            private string name;

            public Sphere(string name, double r)
            {
                this.r = r;
                this.name = name;
            }

            public override double GetSquare()
            {
                double s = Math.PI * 4 * r * r;
                Console.WriteLine(" ");
                Console.WriteLine("Full Square of {0} = {1}", name, s);
                return s;
            }
            public override double GetVolume()
            {
                double v = Math.PI * 4 / 3 * r * r * r;
                Console.WriteLine(" ");
                Console.WriteLine("Volume of {0} = {1}", name, v);
                Console.WriteLine("___________________________");
                return v;
            }

        }

        class Cube : VolumeFigure
        {
            private double l;
            private string name;

            public Cube(string name, double l)
            {
                this.l = l;
                this.name = name;
            }

            public override double GetSquare()
            {
                double s = 6 * l * l;
                Console.WriteLine(" ");
                Console.WriteLine("Full Square of {0} = {1}", name, s);
                return s;
            }
            public override double GetVolume()
            {
                double v = l * l * l;
                Console.WriteLine(" ");
                Console.WriteLine("Volume of {0} = {1}", name, v);
                Console.WriteLine("___________________________");
                return v;
            }

        }

        class Cone : VolumeFigure
        {
            private double r, h, l;
            private string name;

            public Cone(string name, double r, double h, double l)
            {
                if (((r + h) > l) && ((l + h) > r) && ((r + l) > h))
                {
                    this.r = r;
                    this.h = h;
                    this.l = l;
                    this.name = name;
                }
                else
                {
                    Console.WriteLine("Can't use such parameters for a cone");
                    this.r = 7;
                    this.h = 8;
                    this.l = 9;
                    this.name = "Variant of a cone";
                }
            }

            public override double GetSquare()
            {
                double s = Math.PI * r * (r * l);
                Console.WriteLine(" ");
                Console.WriteLine("Full Square of {0} = {1}", name, s);
                return s;
            }
            public override double GetVolume()
            {
                double v = Math.PI * 1 / 3 * r * r * h;
                Console.WriteLine(" ");
                Console.WriteLine("Volume of {0} = {1}", name, v);
                Console.WriteLine("___________________________");
                return v;
            }

        }
    }
}



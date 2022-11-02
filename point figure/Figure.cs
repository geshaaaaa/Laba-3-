using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavd 
{
     class Figure
    {
        enum typeoffigure
        {
            trikut = 1,
            chetkut = 2,
            fivekut = 3
        }
    
        private Point A;
        private Point B;
        private Point C;
        private Point D;
        private Point E;
        private string figura;
        private double _perimetr;
        public double Perimetr
        {
            get { return _perimetr; }
            set { _perimetr = value; }
        }

        public Figure (Point A, Point B, Point C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            figura = typeoffigure.trikut.ToString();

        }
        public Figure(Point A, Point B, Point C,Point D)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            figura = typeoffigure.chetkut.ToString();
        }
        public Figure(Point A, Point B, Point C,Point D,Point E)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            this.E = E;
            
            figura = typeoffigure.fivekut.ToString();
        }
        

         public   double LengthSide (Point A, Point B)
        {
           
            return Math.Sqrt(Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y), 2));            
        }
       public double PerimeterCalculator()
        {
           
            
            double perimetr;
            perimetr = Perimetr;
            if (figura == typeoffigure.trikut.ToString())
            {
                perimetr = LengthSide(A, B) + LengthSide(A, C) + LengthSide(B, C);
                
            }

            else if (figura == typeoffigure.chetkut.ToString())
            {
                perimetr = LengthSide(A, B) + LengthSide(A, D) + LengthSide(B, C) + LengthSide(C, D);
            }
            else if (figura == typeoffigure.fivekut.ToString())
            {
                perimetr = LengthSide(A, B) + LengthSide(A, E) + LengthSide(B, C) + LengthSide(C, D) + LengthSide(D, E);
            }
            return perimetr;

        }

        static void Main(string[] args)
        {



            Point A = new Point(1, 3, "A");
            Point B = new Point(2, 3, "B");
            Point C = new Point(0, 3, "C");
            Point D = new Point(2, 3, "D");
            Point E = new Point(1, 1, "E");

            Figure trikut = new Figure(A, B, C);
            Figure chetkut = new Figure(A, B, C, D);
            Figure pyatkut = new Figure(A, B, C, D);
            Console.WriteLine(trikut.PerimeterCalculator());
            Console.WriteLine(chetkut.PerimeterCalculator());
            Console.WriteLine(pyatkut.PerimeterCalculator());
        }



    }
}

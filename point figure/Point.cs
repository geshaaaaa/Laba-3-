using System;
using System.Globalization;
namespace zavd
{
    class Point
    {
        
        private int x;
        private int y;
        private string namedot = "";
        public int X
           
        { get { return x; } set { x = value; } }
        public int Y 
        { get { return y; } set { y = value; } }
       public string Namedot
            { get { return namedot; } set { namedot = value; } }

        public Point(int y1, int x1, string nameoffigure = "")
        {
            x1 = X;
            y1 = Y;
            nameoffigure = Namedot;

        }
       

    }
}

    
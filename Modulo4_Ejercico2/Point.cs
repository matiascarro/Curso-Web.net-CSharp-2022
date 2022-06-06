using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo4_Ejercico2
{
    public class Point: IEquatable<Point>
    {
        
        int x, y; // Campos
        public Point() // Constructor sin parámetros parameterless
        {
            this.x = 0;
            this.y = 0;
        }
        public Point(int x, int y) // Constructor común
        {
            this.x = x; this.y = y;
        }

        public int X // Propiedad
        {
            get { return x; }
            set { x = value; }
        }
        public int Y // Propiedad
        {
            get { return y; }
            set { y = value; }
        }

        //Operadores de igualdad
        public static bool operator ==(Point p1, Point p2)
        {
            return ((p1.x == p2.x) && (p1.y == p2.y));
        }
        public static bool operator !=(Point p1, Point p2)
        {
            return (!(p1 == p2));
        }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.x + p2.x, p1.y + p2.y);
        }

        public bool Equals(Point? other)
        {
            throw new NotImplementedException();
        }
    }
}

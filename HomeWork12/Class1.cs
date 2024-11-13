using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12
{
    static class Circle
    {
        public const double Pi = Math.PI;
        static public double GetLong(double r)
        {
                  return 2 * Pi * r;
        }
        static public double GetSquare(double r)
        {
            return Pi * Math.Pow(r,2);
        }
        static public bool GetContains(double r, double x , double y)
        {
            return (r>x || r>y);
        }
        static public bool GetContainsFor(double r, double x, double y)
        {
            return (r == x && r == y);
        }
    }
}

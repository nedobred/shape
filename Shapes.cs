using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using shape;
using shapes;

namespace shapes
{
    abstract class Shapes
    {
        public abstract string NameShape { get;}
        
        public abstract double sideA { get; set; }
        public abstract double sideB { get; set; }
        public abstract double sideC { get; set; }
        public abstract double sideD { get; set; }


        public virtual double PerimeterShape(double sideA, double sideB, double sideC, double sideD)
        {
            return sideA + sideB + sideB + sideC + sideD;
        }

        ////public virtual int SquareShape(int sideA, int sideB, int sideC, int sideD)
        ////{
        ////        return sideA * sideB * sideC * sideD;
        ////}

        public virtual double SquareShape(double sideA, double sideB, double sideC, double sideD)
        {
            return sideA * sideB * sideC * sideD;
        }
    }
}


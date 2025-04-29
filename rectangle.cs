using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shapes;

namespace shapes
{
    internal class Rectangle : Shapes
    {
        string _nameRectangle;
        double _sideA;
        double _sideB;
        double _sideC;
        double _sideD;
        public override string NameShape
        {
            get => _nameRectangle = "Прямоугольник";
        }


        public override double sideA
        {
            get => _sideA;
            set => _sideA = value;
        }

        public override double sideB
        {
            get => _sideB;
            set => _sideB = value;
        }

        public override double sideC
        {
            get => _sideC;
            set => _sideC = value;
        }
        public override double sideD
        {
            get => _sideD;
            set => _sideD = value;
        }


        public override double PerimeterShape(double sideA, double sideB, double sideC, double sideD)
        {
            if ((sideA + sideB) > sideC || (sideA + sideC) > sideB || (sideA + sideB > sideC))
            {
                return sideA + sideB + sideC + sideD;
            }
            else
                return 0;
        }



        public override double SquareShape(double sideA, double sideB, double sideC, double sideD)
        {
            if ((sideA + sideB) > sideC || (sideA + sideC) > sideB || (sideA + sideB > sideC))
            {
                return sideA * sideB;
            }
            else
                return 0;
        }
    }
}

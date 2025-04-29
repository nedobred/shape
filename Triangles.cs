using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shapes;

namespace shape
{
    internal class Triangles : Shapes
    {
        string _nameTriangl;
        double _sideA;
        double _sideB;
        double _sideC;
        double _sideD;
        public override string NameShape
        {
            get => _nameTriangl = "Треугольник";
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
            get => _sideD = 0;
            set => _sideD = value;
        }

        public override double PerimeterShape(double sideA, double sideB, double sideC, double sideD = 0)
        {
            if ((sideA + sideB) > sideC || (sideA + sideC) > sideB || (sideA + sideB > sideC))
            {
                return sideA + sideB + sideC;
            }
            else
                return 0;
        }

        // Формула для расчёта площади треугольника: S = SQRT(p(p - a) (p - b) (p - c)),
        // где
        // S — площадь треугольника,
        // a, b, c — длина стороны,
        // h — высота треугольника,
        // p - полупериметр
        // p = 1/2 (a + b + c)
        public override double SquareShape(double sideA, double sideB, double sideC, double sideD = 0)
        {
            if ((sideA + sideB) > sideC || (sideA + sideC) > sideB || (sideA + sideB > sideC))
            {
                double halfMeter = 0;
                double result = 0;
                halfMeter = 0.5 * (sideA + sideB + sideC);
                result = Math.Sqrt(halfMeter * ((halfMeter - sideA) * (halfMeter - sideB) * (halfMeter - sideC)));
                return Math.Round(result, 3);
            }
            else
                return 0;
        }
    }
}

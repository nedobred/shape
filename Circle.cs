using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shapes;

namespace shape
{
    internal class Circle : Shapes
    {
        string _nameCircle;
        double _sideA;
        double _sideB;
        double _sideC;
        double _sideD;

        public override string NameShape
        {
            get => _nameCircle = "Окружность";
        }


        public override double sideA
        {
            get => _sideA;
            set => _sideA = value;
        }

        public override double sideB
        {
            get => _sideB = 0;
            set => _sideB = value;
        }

        public override double sideC
        {
            get => _sideC = 0;
            set => _sideC = value;
        }
        public override double sideD
        {
            get => _sideD = 0;
            set => _sideD = value;
        }

        public override double PerimeterShape(double sideA, double sideB=0, double sideC = 0, double sideD = 0)
        {
                return  2.00 * 3.14*sideA;
        }

        public override double SquareShape(double sideA, double sideB = 0, double sideC = 0, double sideD = 0)
        {
                return 2.00 * 3.14 * sideA*sideA;
        }


    }
}

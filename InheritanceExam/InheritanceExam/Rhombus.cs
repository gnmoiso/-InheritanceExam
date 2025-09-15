using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExam
{
    public class Rhombus : Square
    {
        private double _d1;
        private double _d2;

        public double D1 
        { 
            get => _d1; 
            set => _d1 = ValidateD1(value);
        }
        public double D2 
        { 
            get => _d2; 
            set => _d2 = ValidateD2(value);
        }

        public Rhombus(string Name, double a, double d1, double d2) : base(Name, a)
        {
            D1 = d1;
            D2 = d2;
        }

        private double ValidateD1(double D1)
        {
            if (D1 <= 0)
            {
                throw new Exception($"The Diagonal {D1} isn´t Valid");
            }
            return D1;
        }
        private double ValidateD2(double D2)
        {
            if (D2 <= 0)
            {
                throw new Exception($"The Diagonal {D2} isn´t Valid");
            }
            return D2;
        }
        public override double GetArea() => (D1 * D2) / 2;
        public override double GetPerimeter() => 4 * A;
    }
}

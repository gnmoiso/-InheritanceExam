using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExam
{
    internal class Trapeze : Triangle
    {
        private double _d;

        public double D 
        { 
            get => _d; 
            set => _d = ValidateD(value);
        }

        public Trapeze(string Name, double a, double b, double c, double d, double h) : base(Name, a, b, c, h) => D = d;

        private double ValidateD(double value)
        {
            if (value <= 0)
            {
                throw new Exception($"The Side D {value} isn´t Valid");
            }
            return value;
        }
        public override double GetArea() => (B + D) * (H / 2);
        public override double GetPerimeter() => A + B + C + D;
    }
}

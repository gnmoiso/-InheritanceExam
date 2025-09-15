using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExam
{
    internal class Kite : Rhombus
    {
        private double _b;

        public double B 
        { 
            get => _b; 
            set => _b = ValidateB(value);
        }

        public Kite(string Name, double a, double b, double d1, double d2) : base(Name, a, d1, d2) => B = b;

        private double ValidateB(double B)
        {
            if (B <= 0)
            {
                throw new Exception($"The Base {B} isn´t Valid");
            }
            return B;
        }
        public override double GetArea() => (D1 * D2) / 2;
        public override double GetPerimeter() => 2 * (A + B);
    }
}

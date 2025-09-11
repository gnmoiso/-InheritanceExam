using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExam
{
    public class Rectangle : Square
    {
        private double _b;

        public double B
        {
            get => _b;
            set => _b = ValidateB(value);
        }

        public Rectangle(string Name, double a, double b) : base(Name, a) => B = b;

        private double ValidateB(double value) => value;
        public override double GetArea() =>  A * B;
        public override double GetPerimeter() => 2 * (A + B);
    }
}

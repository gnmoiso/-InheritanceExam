using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExam
{
    internal class Parallelogram : Rectangle
    {
        private double _h;

        public double H 
        { 
            get => _h; 
            set => _h = ValidateH(value);
        }

        public Parallelogram(string Name, double a, double b, double h) : base(Name, a, b) => H = h;

        private double ValidateH(double value) => value;
        public override double GetArea() => B * H;
        public override double GetPerimeter() => 2 * (A + B);
    }
}

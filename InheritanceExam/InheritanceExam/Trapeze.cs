using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExam
{
    internal class Trapeze : Triangle
    {
        //Camps
        private double _d;

        //Propieties
        public double D 
        { 
            get => _d; 
            set => _d = ValidateD(value);
        }

        //constructor
        public Trapeze(string Name, double a, double b, double c, double d, double h) : base(Name, a, b, c, h) => D = d;

        //methods
        private double ValidateD(double value) => value;
        public override double GetArea() => (B + D) * (H / 2);
        public override double GetPerimeter() => A + B + C + D;
    }
}

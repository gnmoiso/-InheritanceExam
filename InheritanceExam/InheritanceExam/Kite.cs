using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExam
{
    internal class Kite : Rhombus
    {
        //Camps
        private double _b;

        //Propieties
        public double B 
        { 
            get => _b; 
            set => _b = ValidateB(value);
        }

        //Constructor
        public Kite(string Name, double a, double b, double d1, double d2) : base(Name, a, d1, d2) => B = b;

        //Methods
        private double ValidateB(double B) => B;
        public override double GetArea() => (D1 * D2) / 2;
        public override double GetPerimeter() => 2 * (A + B);
    }
}

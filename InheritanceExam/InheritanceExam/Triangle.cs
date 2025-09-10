using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExam
{
    internal class Triangle : Rectangle
    {
        //Camps
        private double _c;
        private double _h;

        //Propieties
        public double C 
        { 
            get => _c;
            set 
            { 
                _c = ValidateC(value); 
            } 
        }
        public double H 
        { 
            get => _h; 
            set 
            {
                _h = ValidateH(value);
            }
        }

        //constructor
        public Triangle(string Name, double a, double b, double c, double h) : base(Name, a, b)
        {
            C = c;
            H = h;
        }

        //methods
        private double ValidateH(double H) => H;
        private double ValidateC(double C) => C;
        public override double GetArea() => (B * H) / 2;
        public override double GetPerimeter() => A + B + C;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExam
{
    internal class Triangle : Rectangle
    {
        private double _c;
        private double _h;

        public double C 
        { 
            get => _c;
            set => _c = ValidateC(value);
        }
        public double H 
        { 
            get => _h; 
            set => _h = ValidateH(value);
        }

        public Triangle(string Name, double a, double b, double c, double h) : base(Name, a, b)
        {
            C = c;
            H = h;
        }

        private double ValidateH(double H)
        {
            if (H <= 0)
            {
                throw new Exception($"The Height {H} isn´t Valid");
            }
            return H;
        }
        private double ValidateC(double C)
        {
            if (C <= 0)
            {
                throw new Exception($"The Height {C} isn´t Valid");
            }
            return C;
        }
        public override double GetArea() => (B * H) / 2;
        public override double GetPerimeter() => A + B + C;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExam
{
    public class Square : GeometricFigure
    {
        private double _a;

        public double A 
        {
            get => _a;
            set => _a = ValidateA(value);
        }

        public Square(string name, double a)
        {
            Name = name;
            A = a;
        }

        private double ValidateA(double value)
        {
            if (value <= 0)
            {
                throw new Exception($"The Area {value} isn´t Valid");
            }
            return value;
        }
        public override double GetArea() => Math.Pow(A, 2);
        public override double GetPerimeter() => 4 * A;
    }
}

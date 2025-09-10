using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExam
{
    public class Square : GeometricFigure
    {
        //Camps
        private double _a;

        //Propieties
        public double A 
        {
            get => _a;
            set => _a = ValidateA(value);
        }

        //Constructor
        public Square(string name, double a)
        {
            Name = name;
            A = a;
        }

        //Methods
        private double ValidateA(double value) => value;
        public override double GetArea() => Math.Pow(A, 2);
        public override double GetPerimeter() => 4 * A;
    }
}

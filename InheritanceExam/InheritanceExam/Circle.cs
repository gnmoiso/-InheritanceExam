using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExam
{
    public class Circle : GeometricFigure
    {
        //Camps
        private double _r;

        public double R 
        {
            get => _r;
            set
            {
                _r = ValidateR(value);
            }
        }

        //Constructor
        public Circle(string name, double r)
        {
            Name = name;
            R = r;
        }

        //Methods
        private double ValidateR(double value)
        {
            if ( value <= 0)
            {
                throw new Exception($"The Radious {value} isn´t Valid");
            }
            return value;
            
        }

        public override double GetArea()
        {
            if (R < 0)
            {
                throw new Exception($"The Radious {R} isn´t Valid");
            }
            return (Math.PI * Math.Pow(R, 2));
        }

        public override double GetPerimeter()
        {
            if (R < 0)
            {
                throw new Exception($"The Radious {R} isn´t Valid");
            }
            return (2 * Math.PI * R);
        }
    }
}

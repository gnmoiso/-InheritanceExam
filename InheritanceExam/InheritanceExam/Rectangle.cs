using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExam
{
    public class Rectangle : Square
    {
        //Camps
        private double _b;



        //Propieties
        public double B
        {
            get => _b;
            set
            {
                _b =ValidateB(value);
            }
        }

        //Constructor
        public Rectangle(string Name, double a, double b) : base(Name, a)
        {
            B = b;
        }

        //Methods
        private double ValidateB(double value)
        { 
            return value;
        }


        public override double GetArea()
        {
            return A * B;
        }

        public override double GetPerimeter()
        {
            return 2 * (A + B);
        }
    }
}

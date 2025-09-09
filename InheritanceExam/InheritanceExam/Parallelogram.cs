using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExam
{
    internal class Parallelogram : Rectangle
    {
        //camps
        private double _h;


        //propieties
        public double H 
        { 
            get => _h; 
            set
            {
                _h = ValidateH(value);
            }
        }

        //constructor
        public Parallelogram(string Name, double a, double b, double h) : base(Name, a, b)
        {
            H = h;
        }


        //methods
        private double ValidateH(double value)
        {
            return value;
        }


        public override double GetArea()
        {
            return B * H;
        }

        public override double GetPerimeter()
        {
            return 2 * (A + B);
        }
    }
}

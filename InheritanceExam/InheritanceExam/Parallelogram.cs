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
        public Parallelogram(string Name, double _a, double _b, double _h) : base(Name, _a, _b)
        {
            H = _h;
        }


        //methods
        private double ValidateH(double value)
        {
            if (value <= 0)
            {
                throw new Exception($"The Height {value} isn´t Valid");
            }
            return value;
        }


        public override double GetArea()
        {
            if (B <= 0 || H <= 0)
            {
                throw new Exception($"The Area {B} or {H} isn´t Valid");
            }
            return B * H;
        }

        public override double GetPerimeter()
        {
            if (A <= 0 || B <= 0)
            {
                throw new Exception($"The Area {A} or {B} isn´t Valid");
            }
            return 2 * (A + B);
        }
    }
}

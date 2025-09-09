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
            set
            {
                _d = ValidateD(value);
            }
        }

        //constructor
        public Trapeze(string Name, double _a, double _b, double _c, double _d, double _h) : base(Name, _a, _b, _c, _h)
        {
            D = _d;
        }

        //methods
        private double ValidateD(double value)
        {
            if (value <= 0)
            {
                throw new Exception($"The Side D {value} isn´t Valid");
            }
            return value;
        }

        public override double GetArea()
        {
            if (B <= 0 || D <= 0 || H <= 0)
            {
                throw new Exception($"The Side {B} or {D} or Height {H} isn´t Valid");
            }
            return (B + D) * (H / 2);
        }

        public override double GetPerimeter()
        {
            if (A <= 0 || B <= 0 || C <= 0 || D <= 0)
            {
                throw new Exception($"The Side {A} or {B} or {C} or {D} isn´t Valid");
            }
            return A + B + C + D;
        }

    }
}

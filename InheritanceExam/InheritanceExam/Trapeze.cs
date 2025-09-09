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

        private double ValidateD(double value)
        {
            if (value <= 0)
            {
                throw new Exception($"The Side D {value} isn´t Valid");
            }
            return value;
        }

        public Trapeze(string Name, float _a, float _b, float _c, float _h, double _d) : base(Name, _a, _b, _c, _h)
        {
            D = _d;
        }

        public override float GetArea()
        {
            if (A <= 0 || B <= 0 || H <= 0)
            {
                throw new Exception($"The Side {A} or {B} or Height {H} isn´t Valid");
            }
            return (float)((double)(A + B) * H / 2);
        }

        public override float GetPerimeter()
        {
            if (A <= 0 || B <= 0 || C <= 0 || D <= 0)
            {
                throw new Exception($"The Side {A} or {B} or {C} or {D} isn´t Valid");
            }
            return (float)((double)A + B + C + D);
        }

    }
}

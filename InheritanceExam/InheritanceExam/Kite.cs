using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExam
{
    internal class Kite : Rhombus
    {
        //Camps
        private float _b;


        //Propieties
        public float B 
        { 
            get => _b; 
            set
            {
                _b = ValidateB(value);
            }
        }


        public Kite(string Name, float _a, float _b, float _d1, float _d2) : base(Name, _a, _d1, _d2)
        {
            B = _b;
        }
        private float ValidateB(float B)
        {
            if (B <= 0)
            {
                throw new Exception($"The Base {B} isn´t Valid");
            }
            return B;
        }

        public override float GetArea()
        {
            if (D1 <= 0 || D2 <= 0)
            {
                throw new Exception($"The Diagonal {D1} or {D2} isn´t Valid");
            }
            return (D1 * D2) / 2;
        }

        public override float GetPerimeter()
        {
            if (A <= 0 || B <= 0)
            {
                throw new Exception($"The Side {A} or {B} isn´t Valid");
            }
            return 2 * (A + B);
        }

    }
}

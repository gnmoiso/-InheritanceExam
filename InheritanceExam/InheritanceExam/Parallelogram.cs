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
        private float _h;


        //propieties
        public float H 
        { 
            get => _h; 
            set
            {
                _h = ValidateH(value);
            }
        }

        //constructor
        public Parallelogram(string Name, float _a, float _b, float _h) : base(Name, _a, _b)
        {
            H = _h;
        }


        //methods
        private float ValidateH(float value)
        {
            if (value <= 0)
            {
                throw new Exception($"The Height {value} isn´t Valid");
            }
            return value;
        }


        public override float GetArea()
        {
            if (A <= 0 || H <= 0)
            {
                throw new Exception($"The Area {A} or {H} isn´t Valid");
            }
            return A * H;
        }

        public override float GetPerimeter()
        {
            if (A <= 0 || B <= 0)
            {
                throw new Exception($"The Area {A} or {B} isn´t Valid");
            }
            return 2 * (A + B);
        }
    }
}

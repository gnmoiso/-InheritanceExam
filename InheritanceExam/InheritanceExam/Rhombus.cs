using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExam
{
    internal class Rhombus : Square
    {
        //Camps
        private float _d1;
        private float _d2;



        //Propieties
        public float D1 
        { 
            get => _d1; 
            set
            {
                _d1 = ValidateD1(value);
            }
        }

        public float D2 
        { 
            get => _d2; 
            set
            {
                _d2 = ValidateD2(value);
            }
        }

        public Rhombus(string Name, float _a, float _d1, float _d2) : base(Name, _a)
        {
            D1 = _d1;
            D2 = _d2;
        }
        private float ValidateD1(float D1)
        {
            if (D1 <= 0)
            {
                throw new Exception($"The Diagonal {D1} isn´t Valid");
            }
            return D1;
        }

        private float ValidateD2(float D2)
        {
            if(D2 <= 0)
            {
                throw new Exception($"The Diagonal {D2} isn´t Valid");
            }
            return D2;
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
            if (A <= 0)
            {
                throw new Exception($"The Side {A} isn´t Valid");
            }
            return 4 * A;
        }

    }
}

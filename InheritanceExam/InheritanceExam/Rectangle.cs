using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExam
{
    internal class Rectangle : Square
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



        public Rectangle(string Name, float _a, float _b) : base(Name, _a)
        {
            B = _b;
        }

        private float ValidateB(float value)
        { 
            if (value <= 0)
            {
                throw new Exception($"The Base {value} isn´t Valid");
            }
            return value;
        }


        public override float GetArea()
        {
            if (A <= 0 || B <= 0)
            {
                throw new Exception($"The Area {A} or {B} isn´t Valid");
            }
            return A * B;
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

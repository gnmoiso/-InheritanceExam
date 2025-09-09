using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExam
{
    public class Square : GeometricFigure
    {
        //Camps
        private float _a;

        //Propieties
        public float A 
        {
            get => _a;
            set
            {
                _a = ValidateA(value);
            }
        }

        public Square(string name, float _a)
        {
            Name = name;
            A = _a;
        }
        //Methods

        private float ValidateA(float value)
        {
            if (value <= 0)
            {
                throw new Exception($"The Area {value} isn´t Valid");
            }
            return value;
        }
        public override float GetArea()
        {
            if (A <= 0)
            {
                throw new Exception($"The Area {A} isn´t Valid");
            }
            return A * A;
        }

        public override float GetPerimeter()
        {
            if (A <= 0)
            {
                throw new Exception($"The Area {A} isn´t Valid");
            }
            return 4 * A;
        }

    

 
    }
}

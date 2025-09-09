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
                A = ValidateA(value);
            }
        }

        //Methods
        public override float GetArea(float A)
        {
            float L = (float)Math.Sqrt(A);
            if (A <= 0)
            {
                throw new Exception($"The Area {A} isn´t Valid");
            }
            return L * L;
        }

        public override float GetPerimeter(float A)
        {
            if (A <= 0)
            {
                throw new Exception($"The Area {A} isn´t Valid");
            }
            return 4 * (float)Math.Sqrt(A);
        }

        private float ValidateA(float A)
        {
            if (A <= 0)
            {
                throw new Exception($"The Area {A} isn´t Valid");
            }
            return A;
        }

        public Square(float _a)
        {
            A = _a;
        }
    }
}

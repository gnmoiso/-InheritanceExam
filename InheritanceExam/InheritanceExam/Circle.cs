using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExam
{
    public class Circle : GeometricFigure
    {
        //Camps
        private float _r;

        //Methods
        public float R 
        {
            get => _r;
            set
            {
                R = ValidateR(value);
            }
        }

        public Circle(float r)
        {
            _r = r;
        }

        private float ValidateR(float R)
        {
            if ( R <= 0)
            {
                throw new Exception($"The Radious {R} isn´t Valid");
            }
            return R;
            
        }

        public override float GetArea(float R)
        {
            if (R < 0)
            {
                throw new Exception($"The Radious {R} isn´t Valid");
            }
            return (float)(Math.PI * Math.Pow(R, 2));
        }

        public override float GetPerimeter(float R)
        {
            if (R < 0)
            {
                throw new Exception($"The Radious {R} isn´t Valid");
            }
            return (float)(2 * Math.PI * R);
        }
    }
}

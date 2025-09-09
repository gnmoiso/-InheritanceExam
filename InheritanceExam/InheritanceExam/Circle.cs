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
                _r = ValidateR(value);
            }
        }

        public Circle(string name, float r)
        {
            Name = name;
            R = r;
        }

        private float ValidateR(float value)
        {
            if ( value <= 0)
            {
                throw new Exception($"The Radious {value} isn´t Valid");
            }
            return value;
            
        }

        public override float GetArea()
        {
            if (R < 0)
            {
                throw new Exception($"The Radious {R} isn´t Valid");
            }
            return (float)(Math.PI * Math.Pow(R, 2));
        }

        public override float GetPerimeter()
        {
            if (R < 0)
            {
                throw new Exception($"The Radious {R} isn´t Valid");
            }
            return (float)(2 * Math.PI * R);
        }
    }
}

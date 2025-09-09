using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExam
{
    internal class Triangle : Rectangle
    {
        //Camps
        private double _c;
        private double _h;



        //Propieties
        public double C 
        { 
            get => _c;
            set 
            { 
                _c = ValidateC(value); 
            } 
        }


        public double H 
        { 
            get => _h; 
            set 
            {
                _c = ValidateH(value);
            }
        }


        //constructor
        public Triangle(string Name, float _a, float _b, double _c, double _h) : base(Name, _a, _b)
        {
            C = _c;
            H = _h;
        }

        //methods
        private double ValidateH(double H)
        {
            if (H <= 0)
            {
                throw new Exception($"The Height {H} isn´t Valid");
            }
            return H;
        }

        private double ValidateC(double C)
        {
            if (C <= 0)
            {
                throw new Exception($"The Height {C} isn´t Valid");
            }
            return C;
        }

        public override float GetArea() => (float)((double)B * H / 2);

        public override float GetPerimeter() => (float)((double)A + B + C);
    }
}

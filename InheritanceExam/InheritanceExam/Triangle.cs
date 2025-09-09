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
                _h = ValidateH(value);
            }
        }


        //constructor
        public Triangle(string Name, double _a, double _b, double _c, double _h) : base(Name, _a, _b)
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

        public override double GetArea()
        {
            if (B <= 0 || H <= 0)
            {
                throw new Exception($"The Area {B} or {H} isn´t Valid");
            }
            return (B * H) / 2;

        }

        public override double GetPerimeter()
        {
            if (A <= 0 || B <= 0 || C <= 0)
            {
                throw new Exception($"The Area {A} or {B} or {C} isn´t Valid");
            }
            return A + B + C;
        }
    }
}

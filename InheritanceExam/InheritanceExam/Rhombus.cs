using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExam
{
    public class Rhombus : Square
    {
        //Camps
        private double _d1;
        private double _d2;



        //Propieties
        public double D1 
        { 
            get => _d1; 
            set
            {
                _d1 = ValidateD1(value);
            }
        }

        public double D2 
        { 
            get => _d2; 
            set
            {
                _d2 = ValidateD2(value);
            }
        }

        //Constructor
        public Rhombus(string Name, double _a, double _d1, double _d2) : base(Name, _a)
        {
            D1 = _d1;
            D2 = _d2;
        }

        //Methods
        private double ValidateD1(double D1)
        {
            if (D1 <= 0)
            {
                throw new Exception($"The Diagonal {D1} isn´t Valid");
            }
            return D1;
        }

        private double ValidateD2(double D2)
        {
            if(D2 <= 0)
            {
                throw new Exception($"The Diagonal {D2} isn´t Valid");
            }
            return D2;
        }

        public override double GetArea()
        {
            if (D1 <= 0 || D2 <= 0)
            {
                throw new Exception($"The Diagonal {D1} or {D2} isn´t Valid");
            }
            return (D1 * D2) / 2;
        }

        public override double GetPerimeter()
        {
            if (A <= 0)
            {
                throw new Exception($"The Side {A} isn´t Valid");
            }
            return 4 * A;
        }

    }
}

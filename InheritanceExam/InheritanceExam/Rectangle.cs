using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExam
{
    public class Rectangle : Square
    {
        //Camps
        private double _b;



        //Propieties
        public double B
        {
            get => _b;
            set
            {
                _b =ValidateB(value);
            }
        }

        //Constructor
        public Rectangle(string Name, double _a, double _b) : base(Name, _a)
        {
            this.Name = Name;
            A = _a;
            B = _b;

        }

        //Methods
        private double ValidateB(double value)
        { 
            if (value <= 0)
            {
                throw new Exception($"The Base {value} isn´t Valid");
            }
            return value;
        }


        public override double GetArea()
        {
            if (A <= 0 || B <= 0)
            {
                throw new Exception($"The Area {A} or {B} isn´t Valid");
            }
            return A * B;
        }

        public override double GetPerimeter()
        {
            if (A <= 0 || B <= 0)
            {
                throw new Exception($"The Area {A} or {B} isn´t Valid");
            }
            return 2 * (A + B);
        }
    }
}

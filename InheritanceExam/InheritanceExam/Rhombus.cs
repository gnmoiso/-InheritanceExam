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
                D1 = ValidateD1(value);
            }
        }

        public float D2 
        { 
            get => _d2; 
            set
            {
                D2 = ValidateD2(value);
            }
        }

        private float ValidateD1(float value)
        {
            throw new NotImplementedException();
        }

        private float ValidateD2(float value)
        {
            throw new NotImplementedException();
        }
    }
}

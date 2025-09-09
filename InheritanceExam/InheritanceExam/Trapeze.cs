using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExam
{
    public class Trapeze : Triangle
    {
        //Camps
        private float _d;

        //Propieties
        public float D 
        { 
            get => _d;
            set
            { 
                D = ValidateD(value);
            }
            
        }

        //Constructor
        public float GetArea(float B, float D, float H)
        { 
            return (B + D) * H/2; 
        }
        public float GetPerimeter(float A, float B, float C, float D)
        {
            return A + B + C + D;
        }

        public float Trapeze()
        { }
        private float ValidateD(float value)
        {
            throw new NotImplementedException();
        }
    }
}

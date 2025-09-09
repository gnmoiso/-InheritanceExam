using System;

namespace InheritanceExam
{
    public abstract class GeometricFigure
    {
        // Properties
        public string Name { get; set; } = null!;

        // Methods
        public abstract float GetArea(float R);
        public abstract float GetPerimeter(float R);

        public override string ToString()
        {
            return ToString();
        }
    }
}

using System;

namespace InheritanceExam
{
    public abstract class GeometricFigure
    {
        // Properties
        public string Name { get; set; } = null!;

        // Methods
        public abstract float GetArea();
        public abstract float GetPerimeter();
        public override string ToString()
        {
            return $"{Name, -15} | Área: {GetArea(),10:F2} | Perímetro: {GetPerimeter(),10:F2}";
        }
    }
}

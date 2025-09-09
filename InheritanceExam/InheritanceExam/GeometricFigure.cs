using System;

namespace InheritanceExam
{
    public abstract class GeometricFigure
    {
        // Properties
        public string Name { get; set; } = null!;

        // Methods
        public abstract double GetArea();
        public abstract double GetPerimeter();
        public override string ToString()
        {
            return $"{Name,-15} => Area.....: {GetArea(),18:N5}   Perimeter: {GetPerimeter(),18:N5}";
        }

    }
}


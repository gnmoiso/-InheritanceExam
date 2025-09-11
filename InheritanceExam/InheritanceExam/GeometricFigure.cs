using System;

namespace InheritanceExam
{
    public abstract class GeometricFigure
    {
        public string Name { get; set; } = null!;

        public abstract double GetArea();
        public abstract double GetPerimeter();
        public override string ToString() => $"{Name,-18} => Area.....: {GetArea(),18:N5}   Perimeter: {GetPerimeter(),18:N5}";
    }
}


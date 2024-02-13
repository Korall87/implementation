using FALibrary.Figures;

namespace FigureLibrary.Figures
{
    public class Circle : Figure
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Недопустимое значение, радиус должен быть больше 0");
            }
            Radius = radius;
        }

        internal override double СalculateArea()
            => Math.PI * Math.Pow(Radius, 2);
    }
}

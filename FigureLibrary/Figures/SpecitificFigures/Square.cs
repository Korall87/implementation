using FALibrary.Figures;

namespace FigureLibrary.Figures 
{ 
    public class Square : Figure
    {
        public double SideLength { get; private set; }

        public Square(double sideLength)
        {
            if (sideLength <= 0)
            {
                throw new ArgumentException("Недопустимое значение, длина стороны должна быть больше 0");
            }
            SideLength = sideLength;
        }

        internal override double СalculateArea()
            => Math.Round(Math.Pow(SideLength, 2), 2);

    }
}

using FALibrary.Figures;

namespace FigureLibrary.Figures
{
    public class Triangle : Figure
    {
        public double side1 { get; private set; }
        public double side2 { get; private set; }
        public double side3 { get; private set; }

        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 && side2 <= 0 && side3 <= 0)
            {
                throw new ArgumentException("Треугольник не может существовать со сторонами 0 и меньше 0");
            }
            if (side1 + side2 <= side3 || side3 + side1 <= side2 || side3 + side2 <= side1)
            {
                throw new ArgumentException("Треугольник не может существовать с заданными сторонами");
            }

            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        internal override double СalculateArea()
        {
            double perimeter = (side1 + side2 + side3) / 2;
            return Math.Sqrt(perimeter *
                            (perimeter - side1) *
                            (perimeter - side2) *
                            (perimeter - side3));
        }

        /// <summary>
        /// Проверка на прямоугольный треугольник.
        /// </summary>
        /// <returns></returns>
        public bool IsRightTriangle()
        {
            double[] sides = { side1, side2, side3 };
            double[] sortedSides = sides.OrderByDescending(s => s).ToArray();

            return Math.Pow(sortedSides[0], 2) == Math.Pow(sortedSides[1], 2) + Math.Pow(sortedSides[2], 2);
        }
    }
}

using FigureLibrary.Figures;

var circle = new Circle(12);
Console.WriteLine($"Площадь круга с радиусом {circle.Radius} будет равна {circle.RoundedResult()}");

var square = new Square(5);
Console.WriteLine($"Площадь квадрата со стороной {square.SideLength} будет равна {square.RoundedResult()}");

var triangle = new Triangle(3, 4, 6);
Console.WriteLine($"Площадь треугольника со сторонами {triangle.side1}, {triangle.side2}, {triangle.side3}  будет равна {triangle.RoundedResult()}");
Console.WriteLine($"Треугольник прямоугольный: {triangle.IsRightTriangle()}");

Console.ReadLine();
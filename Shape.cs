public class Point {
    public double X { get; set; }
    public double Y { get; set; }

    public Point(double x, double y) {
        X = x;
        Y = y;
    }
}


public abstract class Shape {
    public Point CenterPoint { get; set; }

    public Shape(double x, double y) {
        CenterPoint = new Point(x, y);
    }

    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
}


public class Circle : Shape {
    public double Radius { get; set; }

    public Circle(double radius, double x, double y) : base(x, y) {
        Radius = radius;
    }

    public override double CalculateArea() {
        return Math.PI * Radius * Radius;
    }

    public override double CalculatePerimeter() {
        return 2 * Math.PI * Radius;
    }
}


public class Rectangular : Shape {
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangular(double width, double height, double x, double y) : base(x, y) {
        Width = width;
        Height = height;
    }

    public override double CalculateArea() {
        return Width * Height;
    }

    public override double CalculatePerimeter() {
        return 2 * (Width + Height);
    }
}

public class Triangle : Shape {
    public double FirstSide { get; set; }
    public double SecondSide { get; set; }
    public double ThirdSide { get; set; }

    public Triangle(double firstSide, double secondSide, double thirdSide, double x, double y) : base(x, y) {
        FirstSide = firstSide;
        SecondSide = secondSide;
        ThirdSide = thirdSide;
    }

    public override double CalculateArea() {
        double s = (FirstSide + SecondSide + ThirdSide) / 2;
        return Math.Sqrt(s * (s - FirstSide) * (s - SecondSide) * (s - ThirdSide));
    }

    public override double CalculatePerimeter() {
        return FirstSide + SecondSide + ThirdSide;
    }
}
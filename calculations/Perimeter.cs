public class Perimeter
{
    public static double Square(double side)
    {
        return side * 4;
    }

    public static double Rectangle(double length, double width)
    {
        return 2 * (length + width);
    }

    public static double Triangle(double side1, double side2, double side3)
    {
        return side1 + side2 + side3;
    }

    public static double Trapezium(double slant_side, double top, double bottom)
    {
        return (slant_side * 2) + (top + bottom);
    }

    public static double Trapezium_straight(double slant_side, double top, double bottom, double straight_side)
    {

        return slant_side + top + bottom + straight_side;
    }

    public static double Circle(double radius)
    {
        return Math.PI * (radius * 2);
    }

    
}
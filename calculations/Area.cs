public class Area
{
    public static double Square(double side)
    {
        return side * 4;
    }

    public static double Rectangle(double length, double width)
    {
        return length * width;
    }

    public static double Circle(double radius)
    {
        return Math.PI * radius * radius;
    }

    public static double Trapezium(double top, double bottom, double slant_height)
    {
        double difference = Math.Sqrt((top - bottom) * (top - bottom));

        double triangle_base = difference / 2;

        double hypotenuse_square = slant_height * slant_height;

        double base_square = triangle_base * triangle_base;

        double straight_height = Math.Sqrt(hypotenuse_square - base_square);


        return (0.5 * (top + bottom) * straight_height);

    }

    public static double Trapezium_straight(double top, double bottom, double straight_height){

       return (top + bottom) * 0.5 * straight_height;

    } 

}
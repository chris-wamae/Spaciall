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

    public double Triangle_right_angled(double triagle_base, double straight_height){

        return 0.5 * triagle_base * straight_height;

    }

    public double Triangle_isosceles(double triangle_base,double straight_height){

        return 0.5 *triangle_base * straight_height;
    }

    public double Triangle_isosceles_slant(double triangle_base, double slant_height){

        double straight_height = Calculation_helper.Triangle_height(slant_height, triangle_base * 0.5);

        return triangle_base * 0.5 * straight_height;
    }

    public static double Trapezium(double top, double bottom, double slant_height)
    {
        double difference = Math.Sqrt((top - bottom) * (top - bottom));

        double triangle_base = difference / 2;

        double straight_height = Calculation_helper.Triangle_height(slant_height, triangle_base);

        return (0.5 * (top + bottom) * straight_height);

    }

    public static double Trapezium_straight(double top, double bottom, double straight_height){

       return (top + bottom) * 0.5 * straight_height;

    } 

}
public class Area
{   
    //finds the area of a square when provided with measurements and returns the result
    public static double Square(params double[] sides)
    {
        return sides[0] * sides[0];
    }
    
    //finds the area of a rectangle when provided with measurements and returns the result
    public static double Rectangle(params double[] sides)
    {
        double length = sides[0];
        double width = sides[1];

        return length * width;
    }
    
     //finds the area of a circle when provided with measurements and returns the result
    public static double Circle(params double[] radius)
    {
        return Math.PI * radius[0] * radius[0];
    }
     
    //finds the area of a triangle when provided with measurements and returns the result
    public static double Triangle_right_angled(params double[] sides)
    {

        double triagle_base = sides[0];

        double straight_height = sides[1];

        return 0.5 * triagle_base * straight_height;

    }
    
    //finds the area of a triangle using the diagonal when provided with measurements and returns the result
    public static double Triangle_isosceles_slant(params double[] sides)
    {

        double triangle_base = sides[0];
        double slant_height = sides[1];

        double straight_height = Calculation_helper.Triangle_height(slant_height, triangle_base * 0.5);

        return triangle_base * 0.5 * straight_height;
    }


    //finds the area of a trapezium using the diagonal when provided with measurements and returns the result
    public static double Trapezium_slant(params double[] sides)
    {
        double top = sides[0];
        double bottom = sides[1];
        double slant_height = sides[2];

        double difference = Math.Sqrt((top - bottom) * (top - bottom));

        double triangle_base = difference / 2;

        double straight_height = Calculation_helper.Triangle_height(slant_height, triangle_base);

        return (0.5 * (top + bottom) * straight_height);

    }
     
     //finds the area of a trapezium when provided with measurements and returns the result
    public static double Trapezium_straight(params double[] sides)
    {
        double top = sides[0];
        double bottom = sides[1];
        double straight_height = sides[2];

        return (top + bottom) * 0.5 * straight_height;

    }

}
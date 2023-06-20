public class Perimeter
{    
    //finds the perimeter of a square when provided with measurements and returns the result
    public static double Square(params double[] sides)
    {
        return sides[0] * 4;
    }
    
    //finds the perimeter of a rectangle when provided with measurements and returns the result
    public static double Rectangle(params double[] sides)
    {   
        double length = sides[0];
        double width = sides[1];
       
        return 2 * (length + width);
    }
    
    //finds the perimeter of a triangle when provided with measurements and returns the result
    public static double Triangle(params double[] sides)
    {
        return sides[0] + sides[1] + sides[2];
    }
    
     //finds the perimeter of a trapezium when provided with measurements and returns the result
    public static double Trapezium(params double[] sides)
    {   
        double slant_side = sides[0];
        double top = sides[1];
        double bottom = sides[2];

        return (slant_side * 2) + (top + bottom);
    }
    
    //finds the perimeter of a trapezium with a straight side when provided with measurements and returns the result
    public static double Trapezium_straight(params double[] sides)
    {  
        double slant_side = sides[0];
        double top = sides[1];
        double bottom = sides[2];
        double straight_side = sides[3];

        return slant_side + top + bottom + straight_side;
    }
   
    //finds the perimeter of a circle (circumfrence) when provided with measurements and returns the result
    public static double Circle(params double[] radius)
    {
        return Math.PI * (radius[0] * 2);
    }

    
}
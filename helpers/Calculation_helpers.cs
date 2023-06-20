//calculates the height of a triangle when provides with the base and hypotenuse and returns it
public class Calculation_helper
{
    public static double Triangle_height(double hypotenuse, double triangle_base)
    {
        return Math.Sqrt((hypotenuse * hypotenuse) - (triangle_base * triangle_base));
    }
    
}
public class Areas
{
    //coverts area from Millimetres to any other measurment and returns the result
    public static double Millimetres(double area, String units)
    {
        switch (units)
        {
            case "cm":
                area = area / 100;
                break;
            case "m":
                area = area / 1000000;
                break;
            case "km":
                area = area / 1000000000000;
                break;
        }
        return area;
    }
     
     //coverts area from Centimetres to any other measurment and returns the result

    public static double Centimetres(double area, String units)
    {

        switch (units)
        {

            case "mm":
                area = area * 100;
                break;
            case "m":
                area = area / 10000;
                break;
            case "km":
                area = area / 100000000;
                break;
        }
        return area;

    }
     
     //coverts area from Metres to any other measurment and returns the result
    public static double Metres(double area, String units)
    {

        switch (units)
        {
            case "mm":
                area = area / 1000000;
                break;
            case "cm":
                area = area / 10000;
                break;
            case "km":
                area = area * 1000000;
                break;
        }
        return area;

    }
    
    //coverts area from Kilometres to any other measurment and returns the result
    public static double Kilometres(double area, String units)
    {
        switch (units)
        {
            case "mm":
                area = area * 1000000000000;
                break;
            case "cm":
                area = area * 10000000000;
                break;
            case "m":
                area = area * 1000000;
                break;

        }
        return area;
    }

}
public class Volumes
{   
    //coverts volume from Millimetres to any other measurment and returns the result
    public static double Millimetres(double volume, String units)
    {
        switch (units)
        {
            case "cm":
                volume = volume / 1000;
                break;
            case "m":
                volume = volume / 1000000000;
                break;
            case "km":
                volume = volume / 1000000000000000000;
                break;
        }

        return volume;

    }
    
    //coverts volume from Centimetres to any other measurment and returns the result
    public static double Centimetres(double volume, String units)
    {
        switch (units)
        {
            case "mm":
                volume = volume * 1000;
                break;
            case "m":
                volume = volume / 1000000;
                break;
            case "km":
                volume = volume / 1000000000000000;
                break;
        }
        return volume;
    }
   
    //coverts volume from Metres to any other measurment and returns the result
    public static double Metres(double volume, String units)
    {
        switch (units)
        {
            case "mm":
                volume = volume * 1000000000;
                break;
            case "cm":
                volume = volume * 1000000;
                break;
            case "km":
                volume = volume / 1000000000;
                break;
        }
        return volume;
    }
   
     //coverts volume from Kilometres to any other measurment and returns the result
    public static double Kilometres(double volume, String units)
    {

        switch (units)
        {
            case "mm":
                volume = volume * 1000000000000000000;
                break;
            case "cm":
                volume = volume * 1000000000000000;
                break;
            case "m":
                volume = volume * 1000000000;
                break;
        }
        return volume;
    }
}
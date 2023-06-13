public class Volumes
{
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
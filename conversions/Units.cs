
public class Units
{
     //coverts straight distance from Millimetres to any other measurment and returns the result
    public static double Millimetres(double amount, String unit)
    {
        switch (unit)
        {
            case "km":
                amount = amount / 1000000;
                break;
            case "m":
                amount = amount / 1000;
                break;
            case "cm":
                amount = amount / 10;
                break;
        }
        return amount;
    }
    
     //coverts straight distance from Centimetres to any other measurment and returns the result
    public static double Centimetres(double amount, String units)
    {
        switch (units)
        {
            case "km":
                amount = amount / 100000;
                break;
            case "m":
                amount = amount / 100;
                break;
            case "mm":
                amount = amount * 10;
                break;
        }
        return amount;

    }
    
     //coverts straight distance from Metres to any other measurment and returns the result
    public static double Metres(double amount, String units)
    {

        switch (units)
        {
            case "km":
                amount = amount / 1000;
                break;
            case "cm":
                amount = amount * 100;
                break;
            case "mm":
                amount = amount * 1000;
                break;
        }
     return amount;
    }
    
    //coverts straight distance from Kilometres to any other measurment and returns the result
    public static double Kilometres(double amount, String units){

      switch(units){
        case "mm":
        amount = amount * 1000000;
        break;
        case "cm":
        amount = amount * 100000;
        break;
        case "m":
        amount = amount * 1000;
        break;
      }
        return amount;
    }

}
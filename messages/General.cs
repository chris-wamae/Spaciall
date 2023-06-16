public class General
{
    public static double Calculation_message()
    {
        Console.WriteLine("Hi!");

        Console.WriteLine("What would you like to calculate?");

        Console.WriteLine("1.Perimeter");

        Console.WriteLine("2.Area");

        Console.WriteLine("3.Volume");

        Console.WriteLine("Enter a number and hit enter to continue...");

        double user_choice;

        user_choice = Convert.ToInt32(Console.ReadLine());

        return user_choice;
    }

    public static double Shape_message(double calculation)
    {
        String choice = "";
        switch (calculation)
        {
            case 1:
                choice = "perimeter";
                break;
            case 2:
                choice = "area";
                break;
            case 3:
                choice = "volume";
                break;
        }

        Console.WriteLine($"What would you like to calculate the {choice} for?");

        String[] shapes = { "Square", "Rectangle", "Triangle", "Trapezium", "Circle" };

        double counter = 1;
        foreach (String shape in shapes)
        {
            Console.WriteLine(counter + "." + shape);
            counter = counter + 1;
        }

        double shape_choice = Convert.ToInt32(Console.ReadLine());

        return shape_choice;
    }

    public static void Units_message()
    {
        Console.WriteLine("What units would you like your results in?");

        Console.WriteLine("1.Kilometres");

        Console.WriteLine("2.Metres");

        Console.WriteLine("3.Centimetres");

        Console.WriteLine("4.Millimetres");
        
        String result_units = Choose_unit();

         double find_measurement()
            {
                Console.WriteLine("What are the measurements?");

                double measurement = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("In what unit is this measurement?");

                Console.WriteLine("1.Kilometres");

                Console.WriteLine("2.Metres");

                Console.WriteLine("3.Centimetres");

                Console.WriteLine("4.Millimetres");

                String measurement_unit = Choose_unit();


                if (measurement_unit != result_units && measurement_unit == "km")
                {

                    measurement = Units.Kilometres(measurement, result_units);
                }
                else if (measurement_unit != result_units && measurement_unit == "m")
                {

                    measurement = Units.Metres(measurement, result_units);
                }
                else if (measurement_unit != result_units && measurement_unit == "cm")
                {

                    measurement = Units.Centimetres(measurement, result_units);
                }
                else if (measurement_unit != result_units && measurement_unit == "mm")
                {

                    measurement = Units.Millimetres(measurement, result_units);
                }
                else
                {
                };

            return measurement;

            };

        List <double> measurements = new List<double>();

        measurements.Add(find_measurement());

        bool other_measurement = true;

        while (other_measurement == true)
        {
            Console.WriteLine("Is there any other measurement?");

            Console.WriteLine("1.Yes");

            Console.WriteLine("2.No");

            double new_measurement = Convert.ToInt32(Console.ReadLine());

            if (new_measurement == 1)
            {
                measurements.Add(find_measurement());

               foreach(double meas in measurements){
                Console.WriteLine(meas);
               }
            }
            else
            {
                other_measurement = false;
            }


        }
    }

    public static String Choose_unit()
    {

        String units = "";

        double unit_choice = Convert.ToInt32(Console.ReadLine());


        switch (unit_choice)
        {
            case 1:
                units = "km";
                break;
            case 2:
                units = "m";
                break;
            case 3:
                units = "cm";
                break;
            case 4:
                units = "mm";
                break;
        }

        return units;

    }

}
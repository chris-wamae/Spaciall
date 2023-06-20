public class GetInput
{
    //gets the type of calculation the user would like to perfom and stores it 
    public static double Calculation_type()
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
    //gets the type of shape a user would like to perfom a calculation for and stores it
    public static double Shape_type(double calculation)
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

        String[] perimeter_shapes = { "Square", "Rectangle", "Triangle", "Circle","Trapezium","Trapezium with straight side" };
        String[] area_shapes = { "Square", "Rectangle", "Triangle", "Triangle using slant side","Trapezium","Trapezium using slant side" };
        String[] volume_shapes = { "Cube", "Cuboid", "Sphere", "Cone", "Cone using diagonal", "Square Pyramid","Square Pyramid using diagonal","Triangular Pyramid" };

        double counter = 1;
        if (calculation == 3)
        {
            foreach (String shape in volume_shapes)
            {
                Console.WriteLine(counter + "." + shape);
                counter = counter + 1;
            }


        }
        else if(calculation == 2)
        {
            foreach (String shape in area_shapes)
            {
                Console.WriteLine(counter + "." + shape);
                counter = counter + 1;
            }

        }

        else{
                 foreach (String shape in perimeter_shapes)
            {
                Console.WriteLine(counter + "." + shape);
                counter = counter + 1;
            }

        }


        double shape_choice = Convert.ToInt32(Console.ReadLine());

        return shape_choice;
    }
    
    //gets the type of measurement a user would like their result in
    //gets measurements for a shape and converts them to the result units
    //adds the measurements to a list
    public static List<double> Figure_measurements()
    {
        Console.WriteLine("What units would you like your results in?");

        Console.WriteLine("1.Kilometres");

        Console.WriteLine("2.Metres");

        Console.WriteLine("3.Centimetres");

        Console.WriteLine("4.Millimetres");

        String result_units = Choose_unit();

        double find_measurement()
        {
            Console.WriteLine("What are the Measurements?");

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

        List<double> Measurements = new List<double>();

        Measurements.Add(find_measurement());
        
        //checks if the user wants to provide an additional measurement

        bool other_measurement = true;
        
        while (other_measurement == true)
        {
            Console.WriteLine("Is there any other measurement?");

            Console.WriteLine("1.Yes");

            Console.WriteLine("2.No");

            double new_measurement = Convert.ToInt32(Console.ReadLine());

            if (new_measurement == 1)
            {
                Measurements.Add(find_measurement());
            }
            else
            {
                other_measurement = false;
            }


        }

        return Measurements;
    }
    
    //allows a user to choose the units for their results and measurments
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
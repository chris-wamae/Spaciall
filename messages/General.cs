public class General
{
    public static int Calculation_message()
    {
        Console.WriteLine("Hi!");

        Console.WriteLine("What would you like to calculate?");

        Console.WriteLine("1.Perimeter");

        Console.WriteLine("2.Area");

        Console.WriteLine("3.Volume");

        Console.WriteLine("Enter a number and hit enter to continue...");

        int user_choice;

        user_choice = Convert.ToInt32(Console.ReadLine());

        return user_choice;
    }

    public static int Shape_message(int calculation)
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

        int counter = 1;
        foreach (String shape in shapes)
        {
            Console.WriteLine(counter + "." + shape);
            counter = counter + 1;
        }

        int shape_choice = Convert.ToInt32(Console.ReadLine());

        return shape_choice;
    }

    public static void Units_message()
    {
     Action find_measurement = () => {
        Console.WriteLine("What are the measurements?");

        Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("In what unit is this measurement?");

        Console.WriteLine("1.Kilometres");

        Console.WriteLine("2.Metres");

        Console.WriteLine("3.Centimetres");

        Console.WriteLine("4.Millimetres");

        Convert.ToInt32(Console.ReadLine());

     };
     find_measurement.Invoke();

        

        bool other_measurement = true;

        while (other_measurement == true)
        {
            Console.WriteLine("Is there any other measurement?");

            Console.WriteLine("1.Yes");

            Console.WriteLine("2.No");
            int new_measurement = Convert.ToInt32(Console.ReadLine());

            if (new_measurement == 1)
            {
                find_measurement.Invoke();
            }
            else
            {
                other_measurement = false;
            }


        }
    }
}
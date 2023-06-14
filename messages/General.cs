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

}
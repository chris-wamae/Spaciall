public class General{
    public static int Calculation_message(){
    Console.WriteLine("Hi!");
    Console.WriteLine("What would you like to calculate?");
    Console.WriteLine("Please type 1 for Perimeter, 2 for Area or 3 for Volume and hit enter to continue...");
    int user_choice;
    user_choice = Convert.ToInt32(Console.ReadLine());
    return user_choice;
    }
}
using FitnessBL.Controller;

Console.WriteLine("Welcome to the Fitness program");

Console.WriteLine("Enter your user name");
var name = Console.ReadLine();

//Console.WriteLine("Enter your user gender");
//var gender = Console.ReadLine();

//Console.WriteLine("Enter your user birth date");
//var bithDate = DateTime.Parse(Console.ReadLine());// TODO: Overwrite

//Console.WriteLine("Enter your user weight");
//var weight = double.Parse(Console.ReadLine());

//Console.WriteLine("Enter your user height");
//var height = double.Parse(Console.ReadLine());

var userController = new UserController(name);
if (userController.IsNewUser)
{
    Console.Write("Enter your gender: ");
    var gender = Console.ReadLine();
    var birthDate = ParseDateTime();    
    var weight = ParseDouble("weight");
    var height = ParseDouble("height");

    userController.SetNewUserData(gender, birthDate, weight, height);
}

Console.WriteLine(userController.CurrentUser);

static DateTime ParseDateTime()
{
    DateTime birthDate;
    while (true)
    {
        Console.Write("Enter your user birth date (MM.dd.yyyy): ");
        if (DateTime.TryParse(Console.ReadLine(), out birthDate))
        {
            return birthDate;
            break;
        }
        else
        {
            Console.WriteLine("Invalid birth date format.");
        }
    }
}

static double ParseDouble(string name)
{ 
    while (true)
    {
        Console.Write($"Enter your user {name}: ");
        if (double.TryParse(Console.ReadLine(), out double value))
        {
            return value;
            break;
        }
        else
        {
            Console.WriteLine($"Invalid {name} format.");
        }
    }    
}
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

#pragma warning disable CS8604 // Possible null reference argument for parameter 'userName' in 'UserController.UserController(string userName)'.
var userController = new UserController(name);
#pragma warning restore CS8604 // Possible null reference argument for parameter 'userName' in 'UserController.UserController(string userName)'.
if (userController.IsNewUser)
{
    Console.Write("Enter your gender: ");
    var gender = Console.ReadLine();
    var birthDate = ParseDateTime();    
    var weight = ParseDouble("weight");
    var height = ParseDouble("height");

#pragma warning disable CS8604 // Possible null reference argument for parameter 'genderName' in 'void UserController.SetNewUserData(string genderName, DateTime birthDate, double weight = 1, double height = 1)'.
    userController.SetNewUserData(gender, birthDate, weight, height);
#pragma warning restore CS8604 // Possible null reference argument for parameter 'genderName' in 'void UserController.SetNewUserData(string genderName, DateTime birthDate, double weight = 1, double height = 1)'.
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
#pragma warning disable CS0162 // Unreachable code detected
            break;
#pragma warning restore CS0162 // Unreachable code detected
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
#pragma warning disable CS0162 // Unreachable code detected
            break;
#pragma warning restore CS0162 // Unreachable code detected
        }
        else
        {
            Console.WriteLine($"Invalid {name} format.");
        }
    }    
}
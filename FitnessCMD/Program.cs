using FitnessBL.Controller;

Console.WriteLine("Welcome to the Fitness program");

Console.WriteLine("Enter your user name");
var name = Console.ReadLine();

Console.WriteLine("Enter your user gender");
var gender = Console.ReadLine();

Console.WriteLine("Enter your user birth date");
var bithDate = DateTime.Parse(Console.ReadLine());// TODO: Overwrite

Console.WriteLine("Enter your user weight");
var weight = double.Parse(Console.ReadLine());

Console.WriteLine("Enter your user height");
var height = double.Parse(Console.ReadLine());

var userController = new UserController(name, gender, bithDate, weight, height);
userController.Save();
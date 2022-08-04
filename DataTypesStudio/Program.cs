// A = pi * r * r
// C = 2 * pi * r
//$"string stuff {code insert} more string"


string userRadius;
double radius;
double area;
double circumference;
double diameter;


Console.WriteLine("Enter a radius: ");
userRadius = Console.ReadLine();
radius = double.Parse(userRadius);

area = Math.PI * (Math.Pow(radius, 2)); //Math.Pow is a way to calculate with exponents
circumference = 2 * Math.PI * radius;
diameter = 2 * radius;

Console.WriteLine($"The area of a circle with radius {radius} is {area}");
Console.WriteLine($"The circumference of a circle with radius {radius} is {circumference}");
Console.WriteLine($"The diameter of a circle with radius {radius} is {diameter}");


string userMilesPerGallon;
double milesPerGallon;
double gallons;

Console.WriteLine("\n");
Console.WriteLine("Enter your car's miles per gallon: ");
userMilesPerGallon = Console.ReadLine();
milesPerGallon = double.Parse(userMilesPerGallon);
gallons = circumference / milesPerGallon;

Console.WriteLine($"It will take {gallons} gallons of gas to go around the circle.");
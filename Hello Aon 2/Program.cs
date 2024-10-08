

Console.WriteLine("------------------");
var enduser = "Hayder Wheed";
var endpass = "123";

Console.WriteLine("UserName:");
var name = Console.ReadLine();
Console.WriteLine("Password:");
var pass = Console.ReadLine();

if (name == enduser )
{
    Console.WriteLine("Username IS CORRECT");
}
else
{
    Console.WriteLine("wrong! in username ");
    Console.WriteLine("Credentials rejected ,exiting");
}

if (pass==endpass)
{
    Console.WriteLine("Password IS CORRECT");   
}

else
{
    Console.WriteLine("Wrong in password");
    Console.WriteLine("Credentials rejected ,exiting");
    return;
}
if (string.IsNullOrEmpty(name))
{
    Console.WriteLine("user name canot be null or empty");
    return;
}
if(string.IsNullOrEmpty(pass))
{
    Console.WriteLine("Passord can not be null or empty");
    return;
}

Random random = new Random();
int otp = random.Next(100000, 999999);

if (pass == endpass  && name==enduser)
{
    Console.WriteLine($"your OTP is {otp}");
}


















Console.WriteLine("Hello, World!");
int x = 2;
int y = 3;
Console.WriteLine("x is " + x);
x = 4;
Console.WriteLine("x is " + x);
Console.WriteLine("y is " + y);

float h = 23.3f;
decimal j = 33M;
double g = 1.0;
Console.WriteLine("h is= " + h + " j is= " + j + " g is= " + g);

string firstNAME = "HAYDER ";
Console.WriteLine("first name is: " + firstNAME);
bool isWORKING = true;
Console.WriteLine(isWORKING);

Console.WriteLine("-------------------------------------------------------");

int intvar = 66;
double doublvar = 34.5d;
Console.WriteLine("befor converiton");
Console.WriteLine("int var is = " + intvar );
Console.WriteLine(" doublevar is = " + doublvar );

Console.WriteLine("AFter convertion");
//doublvar = intvar;



Type type =  intvar.GetType();
Console.WriteLine("type is : " + type);
Console.WriteLine("-----------------------------------------------------------------");
int prise = 100;
string inputfield = Convert.ToString(prise);
Console.WriteLine(inputfield);
Console.WriteLine("-----------------------------");
var massage = string.Format("ther are {0} computers", 5);
Console.WriteLine(massage);
Console.WriteLine($"i have {7} computers in my lap");


























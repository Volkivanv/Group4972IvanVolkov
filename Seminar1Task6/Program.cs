Console.WriteLine("Please, input your number!");
double number = double.Parse(Console.ReadLine()??"0");
if (number % 2 == 0) Console.WriteLine("Number "+ number + " is even!"); 
else Console.WriteLine("Number "+ number + " is odd!");

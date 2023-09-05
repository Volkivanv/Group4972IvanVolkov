Console.WriteLine("Input a!");
double a = Double.Parse(Console.ReadLine()??"0");
Console.WriteLine("Input b!");
double b = Double.Parse(Console.ReadLine()??"0");
if (a < b){ 
    Console.WriteLine("Max number is b = " + b);
}else{
    Console.WriteLine("Max number is b = " + a);
};
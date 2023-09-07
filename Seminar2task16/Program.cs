// Задача №16
// Напишите программу, которая принимает 
// на вход два числа и проверяет, является
//  ли одно число квадратом другого.
int a = int.Parse(Console.ReadLine()??"0");
int b = int.Parse(Console.ReadLine()??"0");

bool test1 = a == b*b;
bool test2 = b == a*a;

if(test1){
    Console.WriteLine("Первое квадрат второго");
}else if(test2){
    Console.WriteLine("Второе квадрат первого");
}else{
    Console.WriteLine("Одно не является квадратом другого");
}
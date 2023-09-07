// Задача №11
// Напишите программу, которая выводит 
// случайное трёхзначное число и удаляет 
// вторую цифру этого числа.


System.Random numberGenerator = new System.Random();

    int n = numberGenerator.Next(100, 1000);
    Console.WriteLine("Сгенерировано:" + n);
    char[] DigitChar = n.ToString().ToCharArray();
    string newDigitStr ="";
     newDigitStr = DigitChar[0].ToString() + DigitChar[2].ToString();
     int newDigit = int.Parse(newDigitStr);
    Console.WriteLine(newDigit);
    // Не работает

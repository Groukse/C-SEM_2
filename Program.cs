/*

// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру
// 78 -> 8
// 12 -> 2
// 85 -> 8

void showNumber(){
    int num = new Random(). Next(10, 100);
    int num1 = num / 10;
    int num2 = num % 10;
    Console.Write(num + " -> ");
    if(num > num2){
        Console.Write(num1);
    }
    else{
        Console.Write(num2);
    }
}

showNumber();


// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа

void newFunctional(){
    int num = new Random(). Next(100, 1000);
    int num1 = num / 100 * 10 + num % 10;
    Console.WriteLine(num  + " -> " + num1);
}
newFunctional();


// Напишите программу, которая будет принимать на вход два числа и выводит, является ли второе число кратным первому

void FundDifference(int num1, int num2){
    if(num2 % num1 == 0){
        Console.WriteLine(num2 + " кратно " + num1);
    }
    else{
        int num3 = num2 % num1;
        Console.WriteLine(num2 + " не кратно " + num1 + " остаток " + num3);
    }
}
Console.Write("Введите первое число ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int n2 = Convert.ToInt32(Console.ReadLine());
FundDifference(n1, n2);




// Домашнее задание по второму семминару

// 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

void homeFunction()
{
    Console .Write("Imput number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int num1 = num % 100;
    int num2 = num1 / 10;
    Console.WriteLine("Secont number " + num + " -> " + num2);
}
homeFunction();


// 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

void homeFunction1()
{
    Console.Write("Enter a three-digit number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int num1 = num % 10;
    if (num < 100 || num > 1000){
        Console.WriteLine("No third number");
    }
    else{
        Console.Write("Third number " + num + " -> " + num1);
    }
}
homeFunction1();

*/

// 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

void homeFunction3()
{
    Console.Write("Enter a three-digit number: ");
    int day = Convert.ToInt32(Console.ReadLine());
    if (day < 1 || day > 7){
    Console.WriteLine("Incorrect number");
    }
    else{
        if (day == 1){
        Console.Write("Monday is a working day");
        }
        if (day == 2){
        Console.Write("Tuesday is a working day");
        }
        if (day == 3){
        Console.Write("Wednesday is a working day");
        }
        if (day == 4){
        Console.Write("Thursday is a working day");
        }
        if (day == 5){
        Console.Write("Friday is a working day");
        }
        if (day == 6){
        Console.Write("Saturday is a day off");
        }
        if (day == 7){
        Console.Write("Sunday is a day off");
        }
    }
}
homeFunction3();
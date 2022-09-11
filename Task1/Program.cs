int printTwoNumber(int number)
{
int first=number/100; //находим 1 число
int two=number%100/10; // находим 2 число
int three=number%10; // находим 3 число
return two;
}

int number;
Console.WriteLine("Введите трехзначное число");
number=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(printTwoNumber(number));
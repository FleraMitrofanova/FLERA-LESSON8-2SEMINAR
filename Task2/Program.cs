int printThreeNumber(int number)
{
int first=number/100; //находи 1 число
int two=number%100/10; // находим 2 число
int three=number%10; // находим 3 число


if (first !=0 )
return three; 
else
return 0;
}

int number,res;
string? numberStr="";
Console.WriteLine("Введите трехзначное число");
number=Convert.ToInt32(Console.ReadLine());
int result=0; // задаем переменную, для вычисления длин

for(int tmp=0; tmp%10; tmp++)
{
   Console.WriteLine("Разрядов"+tmp);
}
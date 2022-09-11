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
numberStr = Console.ReadLine();
int size=numberStr.ToString().Length; // вычисляем длину строки
int result=0; // задаем переменную, для вычисления длины
if (size>3)
{
    int tmp= size-3;
    result=size-tmp;
    String subStr=numberStr.Substring(0,result); //обрезаем строку до 3 знаков
    number=Convert.ToInt32(subStr); //присваиваем обрезанную до 3 значений строку и переводим её в число
}
else
{
number=Convert.ToInt32(numberStr); //присваиваем обрезанную до 3 значений строку и переводим её в число ( В ТОМ СЛУЧАЕ ЕСЛИ 3 ЧИСЛА)
}
res=printThreeNumber(number); // присваиваем значение для проверки
if (res==0)
Console.WriteLine("Третье число не назначено");
else
Console.WriteLine(printThreeNumber(number));
bool getDayWeek(int number)
{
int mon=1;
int tue=2;
int wen=3;
int thu=4;
int fri=5;
int sat=6;
int sun=7;
if (number == sun || number == sat )
return true;
else
return false;
}

int number;
Console.WriteLine("Введите день недели");
number=Convert.ToInt32(Console.ReadLine());
bool result = getDayWeek(number);
if (result)
Console.WriteLine("Введёное число выходной");
else
Console.WriteLine("Введёное число будний день");
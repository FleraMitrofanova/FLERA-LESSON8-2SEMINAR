int printThreeNumber(int number)
{
int res = 0;
int count = 0;
int tmp = number;
//Сосчитаем разряды
while(tmp!=0)
{
tmp=tmp/10;
count++;
}
if(count<3)
   Console.WriteLine("Третий разряд пуст");

if(count==3)
   res=number%10;
   
if(count>3)
   {
      int size=count-3;
      int n = 0;
      while(n<size)
         {
            number=number/10;
            n++;
         }
      res=number%10;
   }
return res;
}

int number=0,result =0;
Console.WriteLine("Введите трехзначное число");
number=Convert.ToInt32(Console.ReadLine());
result = printThreeNumber(number);
Console.WriteLine(" В третьем разряде содержится число: " + result);
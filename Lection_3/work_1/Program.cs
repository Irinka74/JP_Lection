﻿// Первая группа 

void Method1()
{
 Console.WriteLine("Автор...");
}
//Method1();

//2. Вторая группа

void Method2(string msg)
{
 Console.WriteLine(msg);
}
//Method2("Текст"); //-выключает запуск


 void Method21(string msg, int count);

{
     int i = 0;
     while (i < count)
    {
     Console.WriteLine(msg);
     i++;
    } 
}
//Method21("Текст" , 4);

//Третья группа

int Method3(); //нет аргумента
  
  {
   return DataTime.Now.Year;
  }

  int year = Method3();

  Console.WriteLine(year);



  //4. Четвертая группа

  string Method4(int count, string text)
{
 int i = 0;
 string result = String.Empty;
    while (i < count)
   {
    result = result + text;
    i++;
   }
return result;
}
string res = Method4(10, “asdf”);
Console.WriteLine(res);




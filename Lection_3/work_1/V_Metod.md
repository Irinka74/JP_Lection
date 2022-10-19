# Группы методов

 ## 1. Первая группа методов *НЕ ПРИНИМАЕТ* и *НИЧЕГО НЕ ВОЗРАЩАЕТ*

 void Method1()
{
 Console.WriteLine("Автор...");
}

Method1();


 ## 2. Вторая группа методов *-> ПРИНИМАЕТ АРГУМЕНТ* и *НИЧЕГО НЕ ВОЗРАЩАЕТ*

 1. void Method2(string msg)
{
 Console.WriteLine(msg);
}
//Method2("Текст"); //-выключает запуск

 2.  void Method2.1(string msg, int count);

   { int i = 0;
    while (i < count)
    {
     Console.WriteLine(msg);
     i++;
    }
   }

Method21("Текст", 4);


## 3. Третья группа методов *НЕ ПРИНИМАЕТ* но может *ВОЗРАЩАТЬ->*

  int Method3(); //нет аргумента
  
  {
   return DataTime.Now.Year;
  }

  int year = Method3();

  Console.WriteLine(year);


 ## 4. Четвертая группа методов *-> ПРИНИМАЕТ* и *ВОЗРАЩАЕТ->* 

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








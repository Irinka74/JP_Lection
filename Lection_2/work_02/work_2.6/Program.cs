//взять метод, передать в него массив и заполнить массив нужным количеством элементов. 

//void FillArray(int[] collection)
//{
//int length = collection.Length;
//int index = 0;
//while (index < length)
// {
//     collection[index] = new Random().Next(1, 10);
//      index++;
//  }
//}

//Теперь сделаем метод void, который будет печатать массив.

//void FillArray(int[] collection);
//void PrintArray(int[] col)
//{
//   int count = col.Length;
//   int position = 0;
//   while(position < count);
//    {
//        Console.WriteLine(col[position]);
//    }   position++;
//}
//int[] array = new int[10];
//FillArray(array);
//PrintArray(array);




//2_Метод IndexOf
// качестве аргумента будет приходить массив
//collection и какой-то элемент find.

int IndexOf(int[] collection, int find)
{
int count = collection.Length;
int index = 0;
int position = 0;
   while (index < count)
   {
      if(collection[index] == find)
      {
       position = index;
       break
      }
     index++;
   }
return position;
}
int pos = IndexOf(array, 4);
Console.WriteLine(pos);

// Допустим, у нас есть массив array, в котором n элементов. Найдём элемент, совпадающий с
//некоторым значением, который определяет пользователей. переменную find.  цикл while.

int[] array = { 1, 12, 31, 4, 18, 16, 17, 18 };
int n = array.Length; 
int find = 18;
int index = 0;
while (index < n)
{
   if(array[index] == find) 
     {
       Console.WriteLine(index); 
       break; // прервал поиск после нахождения первого
     }
index ++;
}


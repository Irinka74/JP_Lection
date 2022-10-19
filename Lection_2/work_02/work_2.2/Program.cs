// Поищем максимум из 9 чисел. воспользуемся функциями,назовём её max. 
//мы работаем с целыми числами, то будем так же возвращать int:int Max(int).наша функция будет проделывать такую работу:
// возьмёт три числа и найдёт из них максимальное. Затем мы возьмём следующие три числа и найдём максимальное, повторим
//это действие несколько раз, а потом устроим суперфинал.
 
int Max(int arg1, int arg2, int arg3)
{
     int result = arg1;
     if (arg2 > result) result = arg2;
     if (arg3 > result) result = arg3;
     return result;
}

int a1 = 2;
int b1 = 21;
int c1 = 39222;
int a2 = 63;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 53;

        //int max1 = Max(a1, b1, c1);
       // int max2 = Max(a2, b2, c2);
       // int max3 = Max(a3, b3, c3);
       //int max = Max(max1, max2, max3);

int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));

Console.WriteLine(max);


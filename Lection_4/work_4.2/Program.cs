// Определим двумерный массив, назовём его matrix и укажем для него,  3 строки и 4 столбца. 
// i (внешний цикл, щёлкающий строки)
// columns — j(внутренний цикл, щёлкающий столбцы). Выводим на экран. 

//int[,] matrix = new int[3, 4];
//for (int i = 0; i < 3; i++)
//{
// for (int j = 0; j < 4; j++)
// {
// Console.Write($"{matrix[i, j]} ");
// }
//Console.WriteLine();
//}

//int[,] matrix = new int[3, 4];
//for (int i = 0; i < matrix.GetLength(0); i++)
//{
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// Console.Write($"{matrix[i, j]} ");
// }
//Console.WriteLine();
//}


void PrintArray(int[,] matr)
{
 for (int i = 0; i < matr.GetLength(0); i++)
 {
 for (int j = 0; j < matr.GetLength(1); j++)
 {
 Console.Write($"{matr[i, j]} ");
 }
 Console.WriteLine();
 }
}
int[,] matrix = new int[3, 4];
PrintArray(matrix);

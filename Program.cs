// дз7:
// // ********************************************************
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] create_matrix_random_double(int i, int j){
//     double[,] mas = new double[i, j];
//     Random rnd = new Random();
//     for(i = 0; i < mas.GetLength(0); i++){
//         for(j = 0; j < mas.GetLength(1); j++){
//             mas[i, j] = rnd.NextDouble() * 100;
//     }}
//     return mas;}


// void print_matrix_double(double[,] mas){
//     Console.Write("[");
//     for(int i = 0; i < mas.GetLength(0); i++){
//         for(int j = 0; j < mas.GetLength(1); j++){
//             System.Console.Write($"{mas[i, j], 20}");
//     }
//     System.Console.WriteLine();
//     }
//     Console.WriteLine($"]");}


// System.Console.WriteLine("Введите количеттво строк и количество столбцов(последовательно, через enter).");
// double[,] matrix = create_matrix_random_double(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
// print_matrix_double(matrix);
// // ********************************************************



// // ********************************************************
// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// long[,] create_matrix_random_int(int i, int j){
//     long[,] mas = new long[i, j];
//     Random rnd = new Random();
//     for(i = 0; i < mas.GetLength(0); i++){
//         for(j = 0; j < mas.GetLength(1); j++){
//             mas[i, j] = rnd.NextInt64(-100, 101);
//     }}
//     return mas;}



// void print_matrix_int(long[,] mas){
//     Console.Write("[");
//     for(int i = 0; i < mas.GetLength(0); i++){
//         for(int j = 0; j < mas.GetLength(1); j++){
//             System.Console.Write($"{mas[i, j], 5}");
//     }
//     System.Console.WriteLine();
//     }
//     Console.WriteLine($"]");}

// long[] find_value(long[,] matr, long val){
//     long[] value = {-1, -1};
//      for(int i = 0; i < matr.GetLength(0); i++){
//         for(int j = 0; j < matr.GetLength(1); j++){
//             if(matr[i, j] == val) {
//                 value[0] = i;
//                 value[1] = j;
//     }}}
//     return value;
// }

// System.Console.WriteLine("Введите количеттво строк и количество столбцов(последовательно, через enter).");
// long[,] matrix1 = create_matrix_random_int(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
// print_matrix_int(matrix1);
// System.Console.WriteLine("Введите значение для поиска");
// long[] find_val = find_value(matrix1, Convert.ToInt64(Console.ReadLine()));
// if(find_val[0] == -1) System.Console.WriteLine("Нет такого элемента");
// else System.Console.WriteLine($"Искомый элемент находится в строке номер {find_val[0] + 1} и столбце номер {find_val[1] + 1}.");
// // ********************************************************


// // ********************************************************
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// long[,] create_matrix_random_int(int i, int j){
//     long[,] mas = new long[i, j];
//     Random rnd = new Random();
//     for(i = 0; i < mas.GetLength(0); i++){
//         for(j = 0; j < mas.GetLength(1); j++){
//             mas[i, j] = rnd.NextInt64(-100, 101);
//     }}
//     return mas;}



// void print_matrix_int(long[,] mas){
//     Console.Write("[");
//     for(int i = 0; i < mas.GetLength(0); i++){
//         for(int j = 0; j < mas.GetLength(1); j++){
//             System.Console.Write($"{mas[i, j], 5}");
//     }
//     System.Console.WriteLine();
//     }
//     Console.WriteLine($"]");}

// void print_matrix_double(double[,] mas){
//     Console.Write("[");
//     for(int i = 0; i < mas.GetLength(0); i++){
//         for(int j = 0; j < mas.GetLength(1); j++){
//             System.Console.Write($"{mas[i, j], 20}");
//     }
//     System.Console.WriteLine();
//     }
//     Console.WriteLine($"]");}


// void print_mas_double(double[] mas){
//     Console.Write("[");
//     for(int i = 0; i < mas.GetLength(0); i++){
//             System.Console.Write($"{mas[i], 20}");
//     }
//     Console.WriteLine($"]");}


// double[] average_colls(long[,] matr){
//     double[] res = new double[matr.GetLength(1)];
//     for(int i = 0; i < matr.GetLength(0); i++){
//         for(int j = 0; j < matr.GetLength(1); j++){
//             res[j] += matr[i,j];
//         }
//     }
//     long len_s = matr.GetLength(0);
//     for(int j = 0; j < matr.GetLength(1); j++){
//         res[j] /=  len_s;
//     }
// return res;
// }


// System.Console.WriteLine("Введите количеттво строк и количество столбцов(последовательно, через enter).");
// long[,] matrix1 = create_matrix_random_int(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
// print_matrix_int(matrix1);
// double[] average_coll = average_colls(matrix1);
// System.Console.WriteLine($"Средние значения по столбцам:");
// print_mas_double(average_coll);
// System.Console.WriteLine($"Для проверки тест из условия:");
// long[,] matrix2 = {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};
// print_mas_double(average_colls(matrix2));
// // ********************************************************



// // ********************************************************
// Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. 
// Отсортировать элементы по возрастанию слева направо и сверху вниз.

// Например, задан массив:
// 1 4 7 2
// 5 9 10 3

// После сортировки
// 1 2 3 4
// 5 7 9 10

// int[] quick_sort(int[] mas, int min_ind, int max_ind){
//     if (min_ind >= max_ind){
//         return mas;
//     }
//     int pivot = get_pivot(mas, min_ind, max_ind);
//     quick_sort(mas, min_ind, pivot - 1);
//     quick_sort(mas, pivot + 1, max_ind);
//     return mas;
// }

// int get_pivot(int[] mas, int min_ind, int max_ind){
//     int pivot = min_ind - 1;
//     for(int i = min_ind; i <= max_ind; i++){
//         if (mas[i] < mas[max_ind]){
//             pivot++;
//             swap(ref mas[pivot],  ref mas[i]);
//         }
//     }
//     pivot++;
//     swap(ref mas[pivot], ref mas[max_ind]);
//     return pivot;
// }

// void swap(ref int leftItem, ref int rightItem)
//         {
//             int temp = leftItem;
//             leftItem = rightItem;
//             rightItem = temp;
//         }

// int[,] create_matrix_random_int(int i, int j){
//     int[,] mas = new int[i, j];
//     Random rnd = new Random();
//     for(i = 0; i < mas.GetLength(0); i++){
//         for(j = 0; j < mas.GetLength(1); j++){
//             mas[i, j] = rnd.Next(-100, 101);
//     }}
//     return mas;}



// void print_matrix_int(int[,] mas){
//     Console.Write("[");
//     for(int i = 0; i < mas.GetLength(0); i++){
//         for(int j = 0; j < mas.GetLength(1); j++){
//             System.Console.Write($"{mas[i, j], 5}");
//     }
//     System.Console.WriteLine();
//     }
//     Console.WriteLine($"]");}



// void sort_matrix_colls(int[,] matr){
//     int rows = matr.GetLength(0);
//     int colls = matr.GetLength(1);

//     int[] m2 = new int[rows];
//     for(int i = 0; i < colls; i++){
//         for(int j = 0; j < rows; j++){
//             m2[j] = matr[j, i];}
//         quick_sort(m2, 0, rows - 1);
//        for(int j = 0; j < rows; j++){
//             matr[j, i] = m2[j];}
// }
// }
// void sort_matrix_rows(int[,] matr){
//     int rows = matr.GetLength(0);
//     int colls = matr.GetLength(1);
//     int[] m1 = new int[colls];
//     for(int i = 0; i < rows; i++){
//         for(int j = 0; j < colls; j++){
//             m1[j] = matr[i, j];}
//         quick_sort(m1, 0, colls - 1);
//         for(int j = 0; j < colls; j++){
//             matr[i, j] = m1[j];}
// }
// }

// void sort_matrix(int[,] matr){
//     int rows = matr.GetLength(0);
//     int colls = matr.GetLength(1);
//     int[] m = new int[rows * colls];
//     int k = 0;
//     for(int i = 0; i < rows; i++){
//         for(int j = 0; j < colls; j++){
//             m[k] = matr[i, j];
//             k +=1;}}
//     quick_sort(m, 0, colls * rows - 1);
//     k = 0;
//     for(int i = 0; i < rows; i++){
//         for(int j = 0; j < colls; j++){
//             matr[i, j] = m[k];
//             k += 1;}}
        
// }


// System.Console.WriteLine("Введите количеттво строк и количество столбцов(последовательно, через enter).");
// int[,] matrix3 = create_matrix_random_int(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
// System.Console.WriteLine("До сортировки:");
// print_matrix_int(matrix3);
// sort_matrix(matrix3);
// System.Console.WriteLine("Отсортировали:");
// print_matrix_int(matrix3);
// int[,] matrix4 = {{1, 4, 7, 2}, {5, 9, 10, 3}};
// System.Console.WriteLine("До сортировки:");
// print_matrix_int(matrix4);
// sort_matrix(matrix4);
// System.Console.WriteLine("Отсортировали:");
// print_matrix_int(matrix4);




// задача 2 HARD необязательная. Считается за четыре обязательных ) то есть три этих и одна с будущего 
//семинара
// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры) , 
//причем чтоб количество элементов было четное. Вывести на экран красивенько таблицей. 
//Перемешать случайным образом элементы массива, причем чтобы каждый элемент гарантированно и только 
//один раз переместился на другое место и выполнить перемешивание за m*n / 2 итераций. 
//То есть если массив три на четыре, то надо выполнить за 6 итераций. 
//И далее в конце опять вывести на экран как таблицу.
// например, на входе массив 2* 3
// 2 3 5
// 1 9 4
// первая итерация перемешивания - выбрали индексы 0,0 и 1,2 случайный образом, поменяли ячейки
// 4 3 5
// 1 9 2
// вторая итерация - индексы 0, 0 и 1,2 не трогаем, так как это уже перемещенные ячейки, выбираем случайным образом из оставшихся ячеек, выбрали ячейки 0, 1 и 0,2, поменяли значения
// 4 5 3
// 1 9 2
// третья итерация - теперь остались только ячейки 1,0 и 1,1, меняем их местами
// 4 5 3
// 9 1 2
Random rnd = new Random();
int[,] create_matrix_random_int(int i, int j){
    int[,] mas = new int[i, j];
    for(i = 0; i < mas.GetLength(0); i++){
        for(j = 0; j < mas.GetLength(1); j++){
            mas[i, j] = rnd.Next(-100, 101);
    }}
    return mas;}



void print_matrix_int(int[,] mas){
    Console.Write("[");
    for(int i = 0; i < mas.GetLength(0); i++){
        for(int j = 0; j < mas.GetLength(1); j++){
            System.Console.Write($"{mas[i, j], 5}");
    }
    System.Console.WriteLine();
    }
    Console.WriteLine($"]");}


void shaffle(int[,] matr){
    int rows = matr.GetLength(0);
    int colls = matr.GetLength(1);
    int[] m = new int[rows * colls];
    
    int k = 0;
    for(int i = 0; i < rows; i++){
        for(int j = 0; j < colls; j++){
            m[k] = matr[i, j];
            k +=1;}}
    int r = 0;
    int[] mark = new int[rows * colls / 2 + 1];
    for(int i = 0; i < rows * colls / 2 + 1; i++){
        if (mark.Contains(i) && i != 0) continue;
        r = rnd.Next(i + 1, m.Length);
        while(mark.Contains(r))
            r = rnd.Next(i + 1, m.Length);
        mark[i] = r;
        System.Console.WriteLine(i + " " + r);
        int temp = m[i];
        m[i] =  m[r];
        m[r] = temp;
        
    }
    k = 0;
    for(int i = 0; i < rows; i++){
        for(int j = 0; j < colls; j++){
            matr[i, j] = m[k];
            k += 1;}}}

void print_mas_int(int[] mas){
    Console.Write("[");
    for(int i = 0; i < mas.GetLength(0); i++){
            System.Console.Write($"{mas[i], 20}");
    }
    Console.WriteLine($"]");}



System.Console.WriteLine("Введите количеттво строк и количество столбцов(последовательно, через enter).");
int[,] matrix3 = create_matrix_random_int(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
System.Console.WriteLine("До перестановки:");
print_matrix_int(matrix3);
shaffle(matrix3);
System.Console.WriteLine("Перемешали:");
print_matrix_int(matrix3);

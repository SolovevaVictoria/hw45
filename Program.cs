// дз 4:
// int count (decimal num) {
//     if (num == 0) return 1;
//     int res = 0;
//     int part1 = (int)num;
//     decimal part2 = num - part1;
//     while(part2 > 0)
//     {
//         part2 *= 10; //передвигаем запятую
//         part2 -= (int)part2; // вычитаем целую часть (всегда будет 0,...): 
//         //дробная часть 0,34, домножили на 10 - получили 3.40, вычли целую часть (3) -получаем 0.40 
//         //и движемся к 0.00
//         res++;
//     }
//     if (part1 == 0) res++;
//     else{
//     while(part1 != 0)
//     {
//         part1 /= 10;
//         res++;
//     }
//     }
//     return res; }

// Console.WriteLine("Введите число");
// decimal number = Convert.ToDecimal(Console.ReadLine());
// System.Console.WriteLine($"колличество цифр числа {number} = {count(number)}");




// ********************************************************
// дз 5:
//  Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] create_mas_random_int(int size, int min_n, int max_n){
//     int[] mas = new int[size];
//     Random rnd = new Random();
//     for(int i = 0; i < mas.Length; i++){
//         mas[i] = rnd.Next(min_n, max_n + 1);
//     }
//     return mas;
// }


// void print_mas(int[] mas){
//     Console.Write("[");
//     for (int i = 0; i < mas.Length - 1; i++){
//         Console.Write(mas[i] + ", ");
// }
// Console.WriteLine($"{mas[mas.Length - 1]}]");
// }

// void print_mas_double(double[] mas){
//     Console.Write("[");
//     for (int i = 0; i < mas.Length - 1; i++){
//         Console.Write(mas[i] + ", ");
// }
// Console.WriteLine($"{mas[mas.Length - 1]}]");
// }

// // int count_even(int[] mas){
// //     int res = 0;
// //     foreach (var item in mas){
// //         if (item % 2 == 0) res++;
// //     }
// //     return res;
// // }


// // Console.WriteLine("Введите размерность массива");
// // int n = Convert.ToInt32(Console.ReadLine());
// // int[] m1 = create_mas_random_int(n, 100, 999);
// // Console.WriteLine("Массив:");
// // print_mas(m1);
// // System.Console.WriteLine($"Количество чётных чисел в массиве: {count_even(m1)}");
// // ********************************************************


// // ********************************************************
// // Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// // Найдите сумму элементов, стоящих на нечётных позициях.
// // [3, 7, 23, 12] -> 19
// // [-4, -6, 89, 6] -> 0
// // int sum_odd_index(int[] mas){
// //     int res = 0;
// //     for(int i = 1; i <mas.Length; i = i + 2){
// //         res += mas[i];
// //     }
// //     return res;
// // }

// // Console.WriteLine("Введите размерность массива");
// // int count = Convert.ToInt32(Console.ReadLine());
// // int[] m2 = create_mas_random_int(count, -10, 10);
// // Console.WriteLine("Массив:");
// // print_mas(m2);
// // System.Console.WriteLine($"Сумма чисел на нечётных позициях: {sum_odd_index(m2)}");
// // ********************************************************



// // ********************************************************
// // Задача 38: Задайте массив вещественных чисел. 
// // Найдите разницу между максимальным и минимальным элементов массива.
// Random rand = new Random();
// double[] create_mas_random_double(int size){
//     double[] mas = new double[size];
//     Random rnd = new Random();
//     for(int i = 0; i < mas.Length; i++){
//         mas[i] = rand.NextDouble() * 100;
//     }
//     return mas;
// }
// double min_item(double[] mas){
//     double res = mas[0];
//     for(int i=1; i < mas.Length; i++){
//         if (mas[i] < res) res = mas[i];
//     }
//     return res;
// }

// double max_item(double[] mas){
//     double res = mas[0];
//     for(int i=1; i < mas.Length; i++){
//         if (mas[i] > res) res = mas[i];
//     }
//     return res;
// }

// Console.WriteLine("Введите размерность массива");
// int count = Convert.ToInt32(Console.ReadLine());
// double[] m3 = create_mas_random_double(count);
// Console.WriteLine("Массив:");
// print_mas_double(m3);
// System.Console.WriteLine($":Разница между максимальным и минимальным элементами массива: {max_item(m3) - min_item(m3)}");
// //********************************************************


// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. 
// Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, 
// среднее арифметическое всех элементов. 
// Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. 
// Найти медианное значение первоначалального массива , 
// возможно придется кое-что для этого дополнительно выполнить.

// int[] create_mas_random_int(int size, int min_n, int max_n){
//     int[] mas = new int[size];
//     Random rnd = new Random();
//     for(int i = 0; i < mas.Length; i++){
//         mas[i] = rnd.Next(min_n, max_n + 1);
//     }
//     return mas;
// }


// void print_mas(int[] mas){
//     Console.Write("[");
//     for (int i = 0; i < mas.Length - 1; i++){
//         Console.Write(mas[i] + ", ");
// }
// Console.WriteLine($"{mas[mas.Length - 1]}]");
// }

// void print_mas_string(string[] mas){
//     for (int i = 0; i < mas.Length; i++){
//         Console.WriteLine(mas[i]);
// }
// }

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

// int[] min_item(int[] mas){
//     int[] res = {0, mas[0]};
//     for(int i=1; i < mas.Length; i++){
//         if (mas[i] < res[0]) {
//             res[0] = i;
//             res[1] = mas[i];
//         }
//     }

//     return res;
// }
// int[] min_ind_item(int[] mas){
//     int[] res = {0, mas[0]};
//     for(int i=1; i > mas.Length; i++){
//         if (mas[i] < res[0]) {
//             res[0] = i;
//             res[1] = mas[i];
//         }
//     }
//     return res;
// }



// int[] max_ind_item(int[] mas){
//     int[] res = {0, mas[0]};
//     for(int i=1; i < mas.Length; i++){
//         if (mas[i] > res[0]) 
//         res[0] = i;
//         res[1] = mas[i];
//     }
//     return res;
// }

// double average(int[] mas){
//     int res = 0;
//     for(int i=0; i < mas.Length; i++)
//         res += mas[i];
//     return (double)res / mas.Length;
// }

// int mediana(int[] mas){
//     quick_sort(mas,0, mas.Length - 1);
//     int res = 0;
//     if (mas.Length % 2 == 0) return (mas[mas.Length / 2 -1] + mas[mas.Length / 2]) / 2;
//     else return mas[mas.Length / 2];
// }

// string[] res(int[] mas){
//     int[] min_i = min_ind_item(mas);
//     int[] max_i = max_ind_item(mas);
//     int median = mediana(mas);
//     string[] result = new string[4];
//     result[0] = $"Минимальный элемент c индексом: {min_i[0]} = {min_i[1]}";
//     result[1] = $"Максимальный элемент c индексом: {max_i[0]} = {max_i[1]}";
//     result[2] = $"Среднее арифметическое: {average(mas)}";
//     result[3] =  $"Медиана: {median}";
//     return result;
// }

// int[] m4 = create_mas_random_int(11, 1,100);
// Console.WriteLine("Массив:");
// print_mas(m4);
// print_mas_string(res(m4));
// Console.WriteLine("Массив после сортировки для проверки:");
// print_mas(m4);
// // ********************************************************



// // ********************************************************
// Задача VERY HARD необязательная Имеется массив случайных целых чисел. 
//Создайте массив, в который попадают числа, описывающие максимальную сплошную возрастающую последовательность. 
//Порядок элементов менять нельзя.
// Одно число - это не последовательность.
// Пример:
// [1, 5, 2, 3, 4, 6, 1, 7] => [1, 7] так как здесь вразброс присутствуют все числа от 1 до 7
// [1, 5, 2, 3, 4, 1, 7, 8 , 15 , 1 ] => [1, 5] так как здесь есть числа от 1 до 5 и эта последовательность длиннее чем от 7 до 8
// [1, 5, 3, 4, 1, 7, 8 , 15 , 1 ] => [3, 5] так как здесь есть числа от 3 до 5 и эта последовательность длиннее чем от 7 до 8

int[] create_mas_random_int(int size, int min_n, int max_n){
    int[] mas = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < mas.Length; i++){
        mas[i] = rnd.Next(min_n, max_n + 1);
    }
    return mas;
}


void print_mas(int[] mas){
    Console.Write("[");
    for (int i = 0; i < mas.Length - 1; i++){
        Console.Write(mas[i] + ", ");
}
Console.WriteLine($"{mas[mas.Length - 1]}]");
}


int max_item(int[] mas){
    int res = mas[0];
    for(int i=1; i < mas.Length; i++){
        if (mas[i] > res) 
        res = mas[i];
    }
    return res;
}

int min_item(int[] mas){
    int res = mas[0];
    for(int i=1; i < mas.Length; i++){
        if (mas[i] < res) 
        res = mas[i];
    }
    return res;
}

int[] max_mas(int[] mas){
    int[] res = new int[2];
    int max_len_mas = 0;
    int len_mas = 0;
    Boolean left_first = true;
    int left = min_item(mas);
    for (int i = min_item(mas); i <= max_item(mas); i++){
        if(mas.Contains(i)){
            if (left_first) {
                left = i;
                left_first = false;
            }
            len_mas++;
               }
        else {
            if(len_mas > max_len_mas) {
                max_len_mas = len_mas;
                res[0] = left;
                res[1] = i - 1;}
            left_first = true;
            len_mas = 0;
        }}
        if(len_mas > max_len_mas) {
            max_len_mas = len_mas;
            res[0] = left;
            res[1] = max_item(mas);
            len_mas = 0;
        }
    if (res[0] == res[1]){
        res[0] = 0;
        res[1] = 0;
    }
    return res;
    }



int[] m7 = {1, 5, 3, 4, 1, 7, 8 , 15 , 1};
int[] m8 = {1, 5, 2, 3, 4, 1, 7, 8 , 15 , 1};
int[] m9 = {1, 5, 2, 3, 4, 6, 1, 7};
int[] m11 = {1,5};
Console.WriteLine("Проверка тестов из задания:");
print_mas(max_mas(m7));
print_mas(max_mas(m8));
print_mas(max_mas(m9));
print_mas(max_mas(m11));
Console.WriteLine("Массив случайных чисел:");
int[] m10 = create_mas_random_int(10, 1, 10);
print_mas(m10);
Console.WriteLine("Подпоследовательность (при нескольких подпоследовательностях равной длины возвращает первую):");
print_mas(max_mas(m10));
// // ********************************************************
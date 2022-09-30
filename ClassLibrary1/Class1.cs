using System;
using System.Collections.Generic;
using System.Linq;

namespace Muchenia
{
    /// <summary>
    /// Класс для поиска 
    /// </summary>
    public static class Eratnosfer
    {
        /// <summary>
        /// Анализирует все числа до верхней границы поиска. При анализе используется метод Эратносфера
        /// </summary>
        /// <param name="n">максимальное число для поиска</param>
        /// <returns>Массив состоящий из true и false, где false свидетельствует о том, 
        /// что число с этим индексом - простое</returns>
        public static bool[] GetMatrix(int n)
        {
            int nSqrt = (int)MathF.Ceiling(MathF.Sqrt(n));
            bool[] matrix = new bool[n + 1];
            for (int i = 2; i <= nSqrt; i++) //цикл прохода по массиву
            {
                if (matrix[i] == false) //если число ещё не проверялось или является простым...
                {
                    var si = i * i;
                    for (int j = si; j <= n; j += i)  //проверяет все числа, начиная с квадрата i до границы, тем самым, создавая решётку.
                    {
                        matrix[j] = true;  //по итогу все числа, кратные i будут помечены true (не являются простыми)
                    }
                }
            }
            matrix[0] = true;
            return matrix;
        }
        /// <summary>
        /// Добавляет в список все простые числа из заданного диапазона
        /// </summary>
        /// <param name="begin">начальный элемент</param>
        /// <param name="end">конечный элемент</param>
        /// <returns>Список простых чисел</returns>
        public static List<int> FilterArray(int begin, int end)
        {
            int[] array = SearchSimpleNumbersEratos(begin, end);
            List<int> simpleNumsList = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                    simpleNumsList.Add(array[i]);
            }
            return simpleNumsList;
        }

        /// <summary>
        /// Ищет простые числа в массиве с заданным диапазоном Алгоритмом Решето Эратосфена
        /// </summary>
        /// <param name="begin">начальный элемент</param>
        /// <param name="end">конечный элемент</param>
        /// <returns>возвращает массив, с простыми и нулевыми числами и нулевыми</returns>

        public static int[] SearchSimpleNumbersEratos(int begin, int end)
        {
            int[] array = new int[end-begin+1];
            for (int i = begin, j = 0; i < end; i++,j++)
            {
                array[j] = i;
            }
            HandlerArray(ref array);
            return array;   
        }
        /// <summary>
        /// Обработка чисел решетом Эратосфена
        /// </summary>
        public static void HandlerArray(ref int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    Step(ref array,array[i], i);
                }
            }
        }
        /// <summary>
        /// Обнуляет элементы массива которые не являются простыми числами (Алгоритм Решета Эратосфена)
        /// </summary>
        /// <param name="item">Стартовое простое число</param>
        /// <param name="start">Индекс стартового числа в массиве</param>
        public static void Step(ref int[] array, int item, int start)
        {
            for (int i = start + item; i < array.Length; i += item)
            {
                array[i] = 0;
            }
        }

        /// <summary>
        /// Преобразует все элементы матрицы чисел.
        /// Если элемент в матрице matrix имеет значение false, то индекс этого элемента соответствует значению простого числа
        /// </summary>
        /// <param name="matrix">Матрица с помеченными индексами простых чисел</param>
        /// <returns>список простых чисел</returns>
        public static List<int> ListFalseIndeces(bool[] matrix)
        {
            List<int> Single = new List<int>();
            for (int i = 0; i < matrix.Length; i++)
            {
                if (!matrix[i])
                    Single.Add(i);
            }
            return Single;
        }
        /// <summary>
        /// Удаляет все элементы, меньшие чем begin
        /// </summary>
        /// <param name="list">список простых чисел</param>
        /// <param name="begin">начальное значение для поиска</param>
        public static void Filter(List<int> list, int begin)
        {
            list.RemoveAll(p => p < begin);
        }
        /// <summary>
        /// Определяет максимальную разницу между двумя соседними простыми числами
        /// </summary>
        /// <param name="list"></param>
        /// <returns>массив из трёх чисел, где 1-ое число - максимальная разница, 
        /// 2-ое и 3-е - соседние простые числа, у которых разность максимально</returns>
        public static int[] MaxDiff1(List<int> list)
        {
            int[] Diff = new int[3] { 0, 0, 0 };

            for (int i = 0; i < list.Count - 1; i++)
            {
                if (Diff[0] < list[i + 1] - list[i])
                {
                    Diff[0] = list[i + 1] - list[i];
                    Diff[1] = list[i + 1];
                    Diff[2] = list[i];
                }

            }
            return Diff;
        }
        /// <summary>
        /// Определяет десяток, в котором максимальное количество простых чисел
        /// </summary>
        /// <param name="list">список простых чисел</param>
        /// <param name="max">максимальное число для поиска</param>
        /// <returns>массив, состоящий из двух чисел, где 1-ый элемент - максимальное количество простых чисел в заданном десятке, 
        /// 2-ой элемент - десяток с максимальным количеством простых чисел</returns>
        public static int[] MaxSimpleNum(List<int> list, int max, int groupBy)
        {
                int count = 0;
            int[] nums = new int[2] { 0, 1 };
            for (int i = 1; i < (max / groupBy) + 1; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    //if (list[j] < i*10 || list[j] > i) continue;
                    //count++;
                    if (list[j] < i * groupBy && list[j] > (i - 1) * groupBy) count++;
                }
                if (nums[0] < count)
                {
                    nums[0] = count;
                    nums[1] = i;
                }
                count = 0;
            }
            return nums;
        }
        /// <summary>
        /// Определяет десяток, в котором минимальное число простых чисел
        /// </summary>
        /// <param name="list">список простых чисел</param>
        /// <param name="max">максимальное число для поиска</param>
        /// <returns>массив, состоящий из двух чисел, где 1-ый элемент - минимальное количество простых чисел в заданном десятке, 
        /// 2-ой элемент - десяток с минимальным количеством простых чисел</returns>
        public static int[] MinSimpleNum(List<int> list, int max, int min, int groupBy)
        {
            int[] nums = new int[2] { groupBy-1, 1 };
            int count = 0;
            for (int i = min/groupBy +1; i < (max / groupBy) + 1; i++)
            {
                for (int j=0; j < list.Count; j++)
                {
                    if (list[j] < i * groupBy && list[j] > (i - 1) * groupBy) count++;
                }
                if (nums[0] > count)
                {
                    nums[0] = count; 
                    nums[1] = i;
                }
                count = 0;
            }
            return nums;
        }
    }
}




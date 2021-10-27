using System;

namespace ClassLib
{
    public class ArrayHelper<T>
    {
        public static void Swap(T[]array, int a,int b)
        {
            if (array == null)
                return;
            if (a == b)
                return;
            if (a >= array.Length || b >= array.Length)
            {
                return;
            }

            T tmp = array[a];
            array[a] = array[b];
            array[b] = tmp;

        }


        public static T[] Concat(T[] array1, T[] array2)
        {
            T[] hlp = null;

            if (array1 == null && array2 == null)
            {
                return null;
            }

            hlp = new T[array1.Length + array2.Length];

            Array.Copy(array1, hlp, array1.Length);
            Array.Copy(array2, 0, hlp, array1.Length, array2.Length);

            return hlp;
        }
    }
}

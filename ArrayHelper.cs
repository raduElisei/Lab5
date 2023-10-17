using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public static class ArrayHelper
    {
        static int min = int.MaxValue;
        static int max = int.MinValue;

        public static (int, int) ArrayMinMax(int[] array)
        {
            if (array.Length > 0)
            {
                if (array[0] > max)
                    max = array[0];

                if (array[0] < min)
                    min = array[0];

                array = array.Skip(1).ToArray();

                ArrayMinMax(array);
            }

            return (min, max);
        }
    }
}

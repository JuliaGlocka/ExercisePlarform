using System;
namespace TrainingSpace
{
	public class TableTests
	{
        public int [] TestTable(int []tableTest, int isGreaterThan)
        {
            int[] result = new int[10];

            {
                for (int i = 0, j = 0; i < tableTest.Length; i++)

                    if (tableTest[i] > isGreaterThan)
                    {
                        result[j] = tableTest[i];
                        j++;
                    }
            }   return result;
        }
    }
}


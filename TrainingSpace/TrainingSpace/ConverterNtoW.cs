using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWord
{
    public class ConverterNtoW
    {
        protected Dictionary<string, string> digitsMap = new Dictionary<string, string>()
        {
            { "1", "jeden" },
            { "2", "dwa" },
            { "3", "trzy" },
        };

        protected Dictionary<string, string> tensMap = new Dictionary<string, string>()
        {
            { "1", "dziesięć" },
            { "2", "dwadzieścia" },
            { "3", "trzydzieści" },
        };

        protected Dictionary<string, string> hundredsMap = new Dictionary<string, string>()
        {
            { "1", "sto" },
            { "2", "dwieście" },
            { "3", "trzysta" },
        };

        protected Dictionary<string, string> teensMap = new Dictionary<string, string>()
        {
            { "1", "jedenaście" },
            { "2", "dwanaście" },
            { "3", "trzynaście" },
        };

        protected Dictionary<string, Func<string, string>> Map;

        public ConverterNtoW()
        {
            Map = new Dictionary<string, Func<string, string>>() //121
                                                                 /*jeżeli 3 pozycja wynosi 0? */
                                                                 //delegaty w słowniku generycznych//
                                                                 //(si) => to lambda//
            {
                { "3_0", (si) => hundredsMap[si] },
                { "3_1", (si) => tensMap[si] },
                { "3_2", (si) => digitsMap[si] },
                { "2_0", (si) => tensMap[si] },
                { "1_0", (si) => digitsMap[si] },

            };
        }

        public virtual string Convert(string number) //123 "123"
        {
            string result = string.Empty;

            for (int i = 0; i < number.Length; i++)
            {
                if (i == 1 && number[i] == '1')
                {
                    result += teensMap[number[i + 1].ToString()];
                    break;
                }
         
                {
                    string key = string.Format("{0}_{1}", number.Length, i);

                    result += Map[key](number[i].ToString()) + " ";
                }

            }

            return result;
        }

        //protected virtual Dictionary<string, string> GetCorrectMap(int counter, int length)
        //{
        //    if (counter == 0)
        //}
    }
}


/*Julia: 
 * 
 * if (number.Length[1] == 1)
 * 
 *      {protected Dictionary<string, string> teensMap = new Dictionary<string, string>()
            {
                 { "1", "jedenaście" },
                 { "2", "dwanaście" },
                 { "3", "trzynaście" },
             };
         }
JAK UMIEŚCIĆ TO W METODZIE, W KLASIE?
*/


/* string.Format method
 * Overloads
Format(String, Object) 	

Replaces one or more format items in a string with the string representation of a specified object.
Format(String, Object[]) 	

Replaces the format item in a specified string with the string representation of a corresponding object in a specified array.
Format(IFormatProvider, String, Object) 	

Replaces the format item or items in a specified string with the string representation of the corresponding object. A parameter supplies culture-specific formatting information.
Format(IFormatProvider, String, Object[]) 	

Replaces the format items in a string with the string representations of corresponding objects in a specified array. A parameter supplies culture-specific formatting information.
Format(String, Object, Object) 	

Replaces the format items in a string with the string representation of two specified objects.
Format(IFormatProvider, String, Object, Object) 	

Replaces the format items in a string with the string representation of two specified objects. A parameter supplies culture-specific formatting information.
Format(String, Object, Object, Object) 	

Replaces the format items in a string with the string representation of three specified objects.
Format(IFormatProvider, String, Object, Object, Object) 	

Replaces the format items in a string with the string representation of three specified objects. An parameter supplies culture-specific formatting information.
 * 
 * 
 */
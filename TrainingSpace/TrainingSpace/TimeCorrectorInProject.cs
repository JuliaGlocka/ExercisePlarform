using System;
namespace TrainingSpace
{
	public class TimeCorrectorInProject
    {
		public static string GetCorrectTime(int hourMinute)
        {
            if (hourMinute < 10)
            {
                return "0" + hourMinute;
            }
            return hourMinute.ToString();
        }



    }
}



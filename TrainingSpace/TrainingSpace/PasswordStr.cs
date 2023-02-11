using System;
namespace TrainingSpace
{
 
    public static class PasswordUtils
    {
        static string spchar = "!@#$%^&*()_+";
        static string cap = "QWERTYUIOPASDFGHJKLZXCVBNM";
        

        public static int PassStrength(string password)
        {
            int result = 0;



            if (password.Length > 8)
                {
                    result += 3;
                }

                foreach (char c in password)
                {
                    result += 1;
                    if (spchar.Contains(c.ToString()))
                    {
                        result += 1;
                    }
                    if (cap.Contains(c.ToString()))
                    {
                        result += 1;
                    }
                }

            
            return result;



            // 0 - 100
            // ? password.Length > 8 + 1 !@#$%^&*()_+ + 3  
        }
    }
}


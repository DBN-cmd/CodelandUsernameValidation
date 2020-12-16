using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodelandandUsernameValidation_Challenges_
{
    class Program
    {
        public static string CodelandUsernameValidation(string str)
        {

            // code goes here  
            //1. The username is between 4 and 25 characters.
            //2. It must start with a letter.
            if (str.Length < 4 || str.Length > 25 || !char.IsLetter(str[0]))
            {
                return "false";
            }

            char[] strChars = str.ToCharArray();

            foreach (char x in strChars)
            {
                if (char.IsLetter(x) || char.IsNumber(x) || x.Equals('_'))
                {

                }

                else
                {
                    return "false";
                }
            }
            //4. It cannot end with an underscore character.

            int strCharsLast = strChars.Count();

            if (strChars[strCharsLast - 1] == '_')
            {
                return "false";
            }

            return str;

        }

        static void Main(string[] args)
        {
            // keep this function call here
            Console.WriteLine("Enter Username:");

            Console.WriteLine(CodelandUsernameValidation(Console.ReadLine()));


            //Codeland Username Validation
            //Have the function CodelandUsernameValidation(str) take the str parameter being passed and determine if the string is a valid username according to the following rules:

            //1. The username is between 4 and 25 characters.
            //2. It must start with a letter.
            //3. It can only contain letters, numbers, and the underscore character.
            //4. It cannot end with an underscore character.

            //If the username is valid then your program should return the string true, otherwise return the string false.
            //Examples
            //Input: "aa_"
            //Output: false
            //Input: "u__hello_world123"
            //Output: true
        }
    }
}
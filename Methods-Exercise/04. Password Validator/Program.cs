using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {

            //•	It should contain 6 – 10 characters(inclusive)
            //•	It should contain only letters and digits
            //•	It should contain at least 2 digits
            const int minPassLenght = 6, maxPassLenght = 10, minPassDigitCount = 2;

            string password = Console.ReadLine();
            if (CheckIsValid(password, maxPassLenght, minPassLenght, minPassDigitCount))
            {
                Console.WriteLine("Password is valid");
            }
        }
        /// <summary>
        ///  The given method validates password.It prints any validation errors and return boolean for validation status.
        /// </summary>
        static bool CheckIsValid(string password, int maxPassLenght, int minPassLenght, int minPassDigitCount)
        {
            bool isPasswordValid = true;
            if (!CheckPasswordLenght(password, minPassLenght, maxPassLenght))
            {
                Console.WriteLine($"Password must be between {minPassLenght} and {maxPassLenght} characters");
                isPasswordValid = false;
            }
            if (!CheckPasswordIsAlphaNumerical(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isPasswordValid = false;
            }
            if (!CheckForMinDigitNeeded(password, minPassDigitCount))
            {
                Console.WriteLine($"Password must have at least {minPassDigitCount} digits");
                isPasswordValid = false;
            }
            if (isPasswordValid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool CheckPasswordLenght(string password, int minPassLenght, int maxPassLenght)
        {
            if (password.Length >= minPassLenght && password.Length <= maxPassLenght)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool CheckPasswordIsAlphaNumerical(string password)
        {
            foreach (char ch in password)
            {
                if (!char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }

        static bool CheckForMinDigitNeeded(string password, int minPassDigitCount)
        {
            int digitCounter = 0;
            foreach (char ch in password)
            {
                if (Char.IsDigit(ch))
                {
                    digitCounter++;
                }
            }
            if (digitCounter >= minPassDigitCount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

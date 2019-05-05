using System;

namespace _04._Password_Validator
{
    class Program
    {
        static bool CheckPasswordCharacters(string pass)
        {
            bool IsValidChars = false;

            if(pass.Length>=6 && pass.Length <= 10)
            {
                IsValidChars = true;
            }

            return IsValidChars;
        }

        static bool CheckPassworgDigits(string pass)
        {
            bool isValidDigits = false;

            int count = 0;

            foreach (char ch in pass)
            {
                if (char.IsDigit(ch))
                {
                    count++;
                }
            }

            if (count >= 2)
            {
                isValidDigits = true;
            }

            return isValidDigits;
        }


        static bool CheckPasswordContent(string pass)
        {
            bool isValidContent = false;

            int count = 0;

            foreach (char ch in pass)
            {
                if (char.IsDigit(ch))
                {
                    count++;
                }
            }

            string lowpass = pass.ToLower();

            foreach (char ch in lowpass)
            {
                for (char i = 'a'; i <= 'z'; i++)
                {
                    if (ch == i)
                    {
                        count++;
                        break;
                    }
                }
            }

            if(count == pass.Length)
            {
                isValidContent = true;
            }

            return isValidContent;
        }



        static void CheckValidPassword(string pass)
        {
            int count = 0;

            if(CheckPasswordCharacters(pass) == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                count++;
            }
            if(CheckPasswordContent(pass) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                count++;
            }
            if(CheckPassworgDigits(pass) == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
                count++;
            }

            if(count == 0)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static void Main(string[] args)
        {
            CheckValidPassword(Console.ReadLine());
        }
    }
}

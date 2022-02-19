using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Validation
    {

        


        // NOTE --> checks only valid characters, (@ % $ , . ^ ...etc not valid)
        public bool validateString(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            for (int i = 0; i < input.Length; i++)
            {
                if ((int)(input[i]) == 32)      // this character is space
                    continue;

                if ((int)(input[i]) < 65 || (int)(input[i]) > 122) //  characters
                    return false;
            }
            return true;
        }

        public bool validatePositiveNumber(string input, bool canBeFloat = false)
        {
            
            // check if empty
            if (string.IsNullOrEmpty(input))
                return false;

            // check if -ve
            if (input[0] == '-')
                return false;

            // check numbers
            for (int i = 0; i < input.Length; i++)
            {
                if (canBeFloat && input[i] == '.')
                    continue;

                if ((int)(input[i]) < 48 || (int)(input[i]) > 57)
                    return false;
            }
            return true;
        }

        public bool validateEmail(string email)
        {
            List<string> allowedDoamis = new List<string>();
            allowedDoamis.Add("@gmail.com");
            allowedDoamis.Add("@yahoo.com");
            allowedDoamis.Add("@oulook.com");
            allowedDoamis.Add("@hotmail.com");

            // Remove the spaces from the start and the end
            string inputEmail = email.Trim(' ');
            int startIndex = inputEmail.IndexOf('@');
            if (startIndex > 0)     // that means @ exists
            {
                string domain = inputEmail.Substring(startIndex);
                if (allowedDoamis.Contains(domain))
                {
                    return true;
                }
                else
                    return false;
            }
            else
            {
                return false;
            }
        }

        public bool _validatePassword(string password, ref string Error)
        {
            if (password == "")
            {
                Error = "Password is required";
                return false;
            }
            int length = password.Length;
            if (length < 8)
            {
                Error = "Password is too short";
                return false;
            }

            return true;
        }

        public bool validateNumberRange(decimal number, int start, int end)
        {
            return number >= start && number <= end;
        }



        //Function to check for any Number
        public void Check_Number(string box_text, ref string box_empty_error, ref string box_wrong_error)
        {

            //Validations for the number
            if (box_text == "" || box_text == null)
            {
                box_empty_error = "empty error";
            }

            string ff = box_text;
            bool vv = false;
            for (int i = 0; i < ff.Length; i++)
            {
                if (ff[i] == '0' || ff[i] == '1' || ff[i] == '2' || ff[i] == '3' || ff[i] == '4' || ff[i] == '5' || ff[i] == '6' || ff[i] == '7' || ff[i] == '8' || ff[i] == '9')
                    continue;
                else
                {
                    vv = true;
                    break;
                }
            }

            if (vv)
                box_wrong_error = "wrong error";

        }

        //Function to check for any String
        public void Check_String(string box_text, ref string box_empty_error, ref string box_wrong_error)
        {
            string fN = box_text;
            if (fN == "" || fN == null)
            {
                box_empty_error = "empty error";
            }

            for (int i = 0; i < fN.Length; i++)
            {
                if (fN[i] == 'a' || fN[i] == 'A' || fN[i] == 'b' || fN[i] == 'B' || fN[i] == 'c' || fN[i] == 'C' || fN[i] == 'd' || fN[i] == 'D' || fN[i] == 'e' || fN[i] == 'E' || fN[i] == 'f' || fN[i] == 'F' || fN[i] == 'g' || fN[i] == 'G' || fN[i] == 'h' || fN[i] == 'H' || fN[i] == 'i' || fN[i] == 'I' || fN[i] == 'j' || fN[i] == 'J' || fN[i] == 'k' || fN[i] == 'K' || fN[i] == 'l' || fN[i] == 'L' || fN[i] == 'm' || fN[i] == 'M' || fN[i] == 'n' || fN[i] == 'N' || fN[i] == 'o' || fN[i] == 'O' || fN[i] == 'p' || fN[i] == 'P' || fN[i] == 'q' || fN[i] == 'Q' || fN[i] == 'r' || fN[i] == 'R' || fN[i] == 'v' || fN[i] == 'V' || fN[i] == 'w' || fN[i] == 'W' || fN[i] == 's' || fN[i] == 'S' || fN[i] == 'z' || fN[i] == 'Z' || fN[i] == 'u' || fN[i] == 'U' || fN[i] == 't' || fN[i] == 'T' || fN[i] == 'x' || fN[i] == 'X' || fN[i] == 'y' || fN[i] == 'Y')
                    continue;
                else
                {
                    box_wrong_error = "wrong error";
                    break;
                }
            }

        }

        //Function to check for any E-mail                       //NEED TO BE EDITED AS IT IS WORKING WRONG 
        //if i insert 25 as example program don't show message that is wrong  88888888888888888888888888888888888888888888888888888888888888888
        public void Check_Email(string email, ref string box_empty_error, ref string box_wrong_error)
        {
            List<string> allowedDoamis = new List<string>();
            allowedDoamis.Add("@gmail.com");
            allowedDoamis.Add("@yahoo.com");
            allowedDoamis.Add("@oulook.com");
            allowedDoamis.Add("@hotmail.com");

            // Remove the spaces from the start and the end
            string inputEmail = email.Trim(' ');
            int startIndex = inputEmail.IndexOf('@');
            if (startIndex > 0)
            {
                string domain = inputEmail.Substring(startIndex);
                if (allowedDoamis.Contains(domain))
                { }
                else
                    box_wrong_error = "wrong error";
            }

            string fN = email;
            if (fN == "" || fN == null)
            {
                box_empty_error = "empty error";
            }

        }

        //Function to check for any password
        public void Check_Password(string password, ref string box_empty_error, ref string box_wrong_error)
        {
            int length = password.Length;
            //Validations for the number
            if (password == "" || password == null)
            {
                box_empty_error = "empty error";
            }
            else if (length < 8)
            {
                box_wrong_error = "wrong error";
            }

            string ff = password;
            bool vv = false;
            for (int i = 0; i < ff.Length; i++)
            {
                if (ff[i] == '0' || ff[i] == '1' || ff[i] == '2' || ff[i] == '3' || ff[i] == '4' || ff[i] == '5' || ff[i] == '6' || ff[i] == '7' || ff[i] == '8' || ff[i] == '9')
                    continue;
                else
                {
                    vv = true;
                    break;
                }
            }

            if (vv)
                box_wrong_error = "wrong error";
        }

        //Function to check for any phone number
        public void Check_Phone_Number(string phone_number, ref string box_empty_error, ref string box_wrong_error)
        {
            int length = phone_number.Length;
            //Validations for the number
            if (phone_number == "" || phone_number == null)
            {
                box_empty_error = "empty error";
            }
            else if (length != 11)
            {
                box_wrong_error = "wrong error";
            }

            string ff = phone_number;
            bool vv = false;
            for (int i = 0; i < ff.Length; i++)
            {
                if (ff[i] == '0' || ff[i] == '1' || ff[i] == '2' || ff[i] == '3' || ff[i] == '4' || ff[i] == '5' || ff[i] == '6' || ff[i] == '7' || ff[i] == '8' || ff[i] == '9')
                    continue;
                else
                {
                    vv = true;
                    break;
                }
            }

            if (vv)
                box_wrong_error = "wrong error";
        }

    }
}

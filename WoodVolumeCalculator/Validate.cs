using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace WoodVolumeCalculator
{
    class Validate
    {
        public Validate()
        {
        }

        public bool isNumber(string text)
        {
            bool status = false;

            double number = 0;

            try
            {
                number = Convert.ToDouble(text);
                status = true;

            }
            catch (Exception e)
            {
                status = false;
            }
            return status;

        }

        public bool isPhoneNumber(string text)
        {
            bool status = false;
            int length = text.Length;
            if (String.IsNullOrEmpty(text))
            {
                status = true;

            }
            else
            {
                foreach (char letter in text)
                {
                    if (char.IsDigit(letter))
                    {
                        status = true;

                    }
                    else
                    {
                        status = false;
                    }
                }

                if (length != 10)
                {
                    status = false;
                }
            }
            return status;
        }
        public bool isNic(string nic)
        {
            bool status = false;

            // text = NulltoString(text);
            if (nic.Length != 10)
            {
                status = false;
            }
            else
            {
                string strRegex = @"[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]" + @"V";
                Regex re = new Regex(strRegex);
                if (re.IsMatch(nic))
                    status = true;
                else
                    status = false;
            }

            return status;
        }
        public bool isEmail(string text)
        {
            bool status = false;

            if (String.IsNullOrEmpty(text))
            {
                status = true;
            }
            else
            {
                // text = NulltoString(text);
                string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                      @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                      @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
                Regex re = new Regex(strRegex);
                if (re.IsMatch(text))
                    status = true;
                else
                    status = false;
            }

            return status;

        }



    }
}

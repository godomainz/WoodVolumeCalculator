using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WoodVolumeCalculator
{
    class Calculations
    {
        public Calculations() 
        {
        }

        public double getCubicFeet(double length, double circumference) 
        {
            return length * Math.Pow(circumference, 2) / 2304;
        }

        public double getBoardFeet(double cubicfeet) 
        {
            return cubicfeet * 12;
        }
        public int getNool(double boardFeet) 
        {
            return Convert.ToInt32(boardFeet * 12);
        }

        public string getResult(int nool) 
        {
            string text = "";
            int remainNool = 0;

            if (nool < 12)
            {
                text = "Cubic feet : " + 0 + " Inches : " + 0 + " Nool :" + nool;
            }
            else if (nool == 12)
            {
                text = "Cubic feet : " + 0 + " Inches : " + 1 + " Nool :" + 0;
            }
            else if (nool > 12 && nool < 144)
            {
                remainNool = nool % 12;
                text = "Cubic feet : " + 0 + " Inches : " + (nool - remainNool) / 12 + " Nool :" + remainNool;
            }
            else if (nool == 144)
            {
                text = "Cubic feet : " + 1 + " Inches : " + 0 + " Nool :" + 0;
            }
            else
            {
                remainNool = nool % 12;
                int inches = Convert.ToInt32((nool - remainNool) / 12);

                text = "Cubic feet : " + (inches - inches % 12) / 12 + " Inches : " + inches % 12 + " Nool :" + remainNool;

            }

            return text;
        }

        public double addCubicFeet(int prevFeet, int prevInches,int feet,int inches) 
        {
            double result = 0;
            int ft = 0;
            int inch = 0;


            try
            {
                if ((prevInches + inches) >= 12)
                {
                    ft = prevFeet + feet + 1;
                    inch = (prevInches + inches) % 12;
                }
                else
                {
                    ft = prevFeet + feet;
                    inch = prevInches + inches;
                }

                string res = String.Concat((ft + "."), inch);
                result = Convert.ToDouble(res);
            }
            catch (Exception e)
            {
                
                MessageBox.Show(e.ToString());
            }

            return result;
        }
    }
}

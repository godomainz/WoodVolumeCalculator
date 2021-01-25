using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WoodVolumeCalculator
{
    public partial class txtCubicFeet : Form
    {
        bool lengthFocused;
        bool cirCumferenceFocused;
        bool cubicFeetFocused;
        Validate val;
        Calculations cal;
        public txtCubicFeet()
        {
            InitializeComponent();
            lengthFocused = false;
            cirCumferenceFocused = false;
            cubicFeetFocused = false;
            val = new Validate();
            cal = new Calculations();

        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (lengthFocused)
            {
                txtLength.SelectedText = "7";
            }
            else if (cirCumferenceFocused)
            {
                txtCircumference.SelectedText = "7";
            }
            else if (cubicFeetFocused) 
            {
                txtEnterFeet.SelectedText = "7";
            }

            
        }

        private void txtCircumference_CursorChanged(object sender, EventArgs e)
        {
           
        }

        private void txtLength_CursorChanged(object sender, EventArgs e)
        {
          
        }

        private TextBox TextFocusedFirstLoop()
        {
           
            foreach (Control tb in this.Controls)
            {
                if (tb is TextBox && tb.Focused)
                {
                    MessageBox.Show(tb.Name);
                    return tb as TextBox;
                }
            }
            return null; 
        }

        private void txtLength_Enter(object sender, EventArgs e)
        {
            
            lengthFocused = true;
            cirCumferenceFocused = false;
            cubicFeetFocused = false;
        }

        private void txtCircumference_Enter(object sender, EventArgs e)
        {
            
            lengthFocused = false;
            cirCumferenceFocused = true;
            cubicFeetFocused = false;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (lengthFocused)
            {
                txtLength.SelectedText = "8";
            }
            else if (cirCumferenceFocused)
            {
                txtCircumference.SelectedText = "8";
            }
            else if (cubicFeetFocused)
            {
                txtEnterFeet.SelectedText = "8";
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (lengthFocused)
            {
                txtLength.SelectedText = "9";
            }
            else if (cirCumferenceFocused)
            {
                txtCircumference.SelectedText = "9";
            }
            else if (cubicFeetFocused)
            {
                txtEnterFeet.SelectedText = "9";
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (lengthFocused)
            {
                txtLength.SelectedText = "4";
            }
            else if (cirCumferenceFocused)
            {
                txtCircumference.SelectedText = "4";
            }
            else if (cubicFeetFocused)
            {
                txtEnterFeet.SelectedText = "4";
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (lengthFocused)
            {
                txtLength.SelectedText = "5";
            }
            else if (cirCumferenceFocused)
            {
                txtCircumference.SelectedText = "5";
            }
            else if (cubicFeetFocused)
            {
                txtEnterFeet.SelectedText = "5";
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (lengthFocused)
            {
                txtLength.SelectedText = "6";
            }
            else if (cirCumferenceFocused)
            {
                txtCircumference.SelectedText = "6";
            }
            else if (cubicFeetFocused)
            {
                txtEnterFeet.SelectedText = "6";
            }
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (lengthFocused)
            {
                txtLength.SelectedText = "1";
            }
            else if (cirCumferenceFocused)
            {
                txtCircumference.SelectedText = "1";
            }
            else if (cubicFeetFocused)
            {
                txtEnterFeet.SelectedText = "1";
            }
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (lengthFocused)
            {
                txtLength.SelectedText = "2";
            }
            else if (cirCumferenceFocused)
            {
                txtCircumference.SelectedText = "2";
            }
            else if (cubicFeetFocused)
            {
                txtEnterFeet.SelectedText = "2";
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (lengthFocused)
            {
                txtLength.SelectedText = "3";
            }
            else if (cirCumferenceFocused)
            {
                txtCircumference.SelectedText = "3";
            }
            else if (cubicFeetFocused)
            {
                txtEnterFeet.SelectedText = "3";
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (lengthFocused)
            {
                txtLength.SelectedText = "0";
            }
            else if (cirCumferenceFocused)
            {
                txtCircumference.SelectedText = "0";
            }
            else if (cubicFeetFocused)
            {
                txtEnterFeet.SelectedText = "0";
            }
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (lengthFocused)
            {
                txtLength.SelectedText = ".";
            }
            else if (cirCumferenceFocused)
            {
                txtCircumference.SelectedText = ".";
            }
            else if (cubicFeetFocused)
            {
                txtEnterFeet.SelectedText = ".";
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {

            try
            {
                if ((val.isNumber(txtLength.Text) && val.isNumber(txtCircumference.Text)) && !cubicFeetFocused)
                {

                    
                    double feet = Convert.ToDouble(txtLength.Text);
                    double cirCumference = Convert.ToDouble(txtCircumference.Text);

                   
                    double cubicFeet = cal.getCubicFeet(feet, cirCumference);

                    double boardFeet = cal.getBoardFeet(cubicFeet);
                    


                    double remainBf = 0;
                    remainBf = Math.Round(boardFeet % 12, 3);

                    int nl = Convert.ToInt32(boardFeet * 12);
                    
                    int nool = cal.getNool(boardFeet);

                    lblNool.Text = Convert.ToString(nool);
                

                    string text = cal.getResult(nool);
                    

                    lblCubicFeet.Text = Convert.ToString(text);
                    txtLength.Text = String.Empty;
                    txtCircumference.Text = String.Empty; 


                }
                else if (cubicFeetFocused) 
                {
                    txtEnterFeet.Text = String.Empty;
                }
                else
                {
                    MessageBox.Show("Please enter a valid number for length and circumference");
                    txtLength.Text=String.Empty;
                    txtCircumference.Text=String.Empty;
                }
            }
            catch (FormatException fEx) 
            {
                MessageBox.Show("Please enter valid numbers for length and circumference");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtLength_KeyPress(object sender, KeyPressEventArgs e)
        {
           // e.Handled = !IsValidCharacter(e);
            string text = e.KeyChar.ToString();
            e.Handled = !IsTextAllowed(text);
        }
        private bool IsValidCharacter(KeyPressEventArgs e)
        {
            bool isValid = true;
            
            return isValid;
        }
        private static bool IsTextAllowed(string text)
        {
            Regex regex = new Regex("[^0-9.\b]+"); //regex that matches disallowed text


            return !regex.IsMatch(text);
        }

        private void txtLength_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
          
        }

        private void txtCircumference_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = e.KeyChar.ToString();
            e.Handled = !IsTextAllowed(text);
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if (val.isNumber(txtLength.Text) && val.isNumber(txtCircumference.Text))
                {


                    double feet = Convert.ToDouble(txtLength.Text);
                    double cirCumference = Convert.ToDouble(txtCircumference.Text);

                    double cubicFeet = Math.Round(feet * Math.Pow(cirCumference, 2) / 2304, 3);

                    double boardFeet = 0;
                    boardFeet = Math.Round(cubicFeet * 12, 3);
                    double remainBf = 0;
                    remainBf = Math.Round(boardFeet % 12, 3);
                    double nool = Math.Round(boardFeet * 12);
                    lblNool.Text = Convert.ToString(nool);

                  

                    string text = "";
                    text = "Cubic feet : " + Math.Round((boardFeet - remainBf) / 12) + " Inches : " + remainBf;

                    
                    lblCubicFeet.Text = Convert.ToString(text);

                }
                else
                {
                    MessageBox.Show("Please enter a valid number for length and circumference");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtCircumference_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEqual.PerformClick();
            }
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            string text = "";
            string newText = "";
            if (lengthFocused)
            {
                text = txtLength.Text;
                if (text.Length != 0)
                {
                    newText = text.Remove(text.Length - 1);
                    txtLength.Text = newText;
                }
            }
            else if (cirCumferenceFocused)
            {
                text = txtCircumference.Text;
                if (text.Length != 0)
                {
                    newText = text.Remove(text.Length - 1);
                    txtCircumference.Text = newText;
                }
            }else if(cubicFeetFocused)
            {
                text = txtEnterFeet.Text;
                if (text.Length != 0)
                {
                    newText = text.Remove(text.Length - 1);
                    txtEnterFeet.Text = newText;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLength.Text = String.Empty;
            txtCircumference.Text = String.Empty;
            txtEnterFeet.Text = String.Empty;
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtLength.Text = String.Empty;
            txtCircumference.Text = String.Empty;
            lblCubicFeet.Text = String.Empty;
            txtEnterFeet.Text = String.Empty;
            lblCubicFeetResult.Text = String.Empty;


        }

        private void txtLength_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEqual.PerformClick();
            }
        }

        private void txtEnterFeet_Enter(object sender, EventArgs e)
        {
            lengthFocused = false;
            cirCumferenceFocused = false;
            cubicFeetFocused = true;
        }

        private void txtEnterFeet_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEnterFeet_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = e.KeyChar.ToString();
            e.Handled = !IsTextAllowed(text);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            try
            {
                string inchesError = "Invalid Cubic Feet \nExamle : 3.11 means 3` 11 \" (3 feet 11 inches)";
                if (cubicFeetFocused)
                {
                    
                        string feetWithInches = " ";

                        if (String.IsNullOrEmpty(lblCubicFeetResult.Text))
                        {
                            feetWithInches = txtEnterFeet.Text;
                            string[] words = feetWithInches.Split('.');
                            int feet = Convert.ToInt32(words[0]);
                            int inches = 0;
                            if (words.Count() == 2)
                            {
                                inches = Convert.ToInt32(words[1]);
                            }

                            if (inches < 12)
                            {
                                lblCubicFeetResult.Text = feetWithInches;
                                txtEnterFeet.Text = String.Empty;
                            }
                            else 
                            {
                                
                                MessageBox.Show(inchesError);
                            }
                        }
                        else
                        {
                            if (val.isNumber(txtEnterFeet.Text))
                            {
                                feetWithInches = lblCubicFeetResult.Text;
                                string[] words = feetWithInches.Split('.');
                                int feet = Convert.ToInt32(words[0]);
                                int inches = 0;
                                if (words.Count() == 2)
                                {
                                    inches = Convert.ToInt32(words[1]);
                                }

                                
                                    string newfeetWithInches = txtEnterFeet.Text;
                                    string[] newWords = newfeetWithInches.Split('.');
                                    int newFeet = Convert.ToInt32(newWords[0]);
                                    int newInches = 0;

                                    if (newWords.Count() == 2)
                                    {
                                        newInches = Convert.ToInt32(newWords[1]);
                                    }

                                    if (newInches < 12)
                                    {
                                        double result = cal.addCubicFeet(feet, inches, newFeet, newInches);
                                        lblCubicFeetResult.Text = Convert.ToString(result);
                                        txtEnterFeet.Text = String.Empty;
                                    }
                                    else 
                                    {
                                        
                                        MessageBox.Show(inchesError);
                                    }
                               
                        }else 
                        {
                                MessageBox.Show("Please enter a valid cubic feet");
                                txtEnterFeet.Text = String.Empty;
                         }

                        }

                    
                    
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtEnterFeet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Add)
            {
                btnPlus.PerformClick();
            }
        }
    }
}

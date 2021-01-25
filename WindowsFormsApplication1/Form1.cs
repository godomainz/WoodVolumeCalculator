using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string con = "Server=127.0.0.1;Uid=root;Pwd=123;Database=san;";
        public Form1()
        {

            con = "Server=127.0.0.1;Uid=root;Pwd=123;Database=san;";
            InitializeComponent();
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                sanEntities db = new sanEntities();
                master ms = new master();
                ms.idmaster = Convert.ToInt16(textBox1.Text);
                ms.name = textBox2.Text;
                db.AddObject("master", ms);
               int val=db.SaveChanges();
               if (val == 0)
               {
                   MessageBox.Show("Unsuccessfull");
               }
               else 
               {
                   MessageBox.Show("Successfull");
               }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }
    }
}

using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace WindowsFormsApp1
{
    public partial class mainForm : MaterialForm
    {
        public mainForm()
        {

           
            InitializeComponent();

            MessageBox.Show("Приветствуем в программе для печати морского паспорта");
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void class11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

          
        }

        private void class11_Click_1(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();

            newForm.Show();
        }

        private void class12_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();

            newForm.Show();
        }

        private void class13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

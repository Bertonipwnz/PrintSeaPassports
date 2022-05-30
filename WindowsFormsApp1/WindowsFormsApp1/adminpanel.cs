using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class adminpanel : MaterialForm
    {
        db db = new db();
        DataSet ds = new DataSet();
        DataSet ds2 = new DataSet();
       // dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
         //   dataGridView1.AllowUserToAddRows = false;
         //    dataGridView1.DataSource = ds.Tables[1];
        public adminpanel()
        {
            InitializeComponent();
            try
            {
                
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                //выборка данных

                MySqlDataAdapter mda = new MySqlDataAdapter("select * from `users`", db.getConnection());
                
                mda.Fill(ds, "Data");
                dataGridView1.DataSource = ds.Tables["Data"];
                MySqlDataAdapter mda2 = new MySqlDataAdapter("select * from `log`", db.getConnection());
                mda2.Fill(ds2, "Data");
                dataGridView2.DataSource = ds2.Tables["Data"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
             
        }

        private void class11_Click(object sender, EventArgs e)
        {

            this.Hide();
            //MessageBox.Show("Добро пожаловать в панель администратора");
            adminpanel newForm1 = new adminpanel();
            newForm1.Show();

            //проверка на наличие данных

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void class12_Click(object sender, EventArgs e)
        {
            string id = textBox4.Text;
            string sid = textBox7.Text;
            string login = textBox5.Text;
            string password = textBox6.Text;
            db db = new db();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand com = new MySqlCommand("UPDATE `users` SET `ID` = @id, `login` = @login , `password` = @password WHERE `ID` = @selectid", db.getConnection());
            com.Parameters.AddWithValue("@ID", id);
            com.Parameters.AddWithValue("@selectid", sid);
            com.Parameters.AddWithValue("@login", login);
            com.Parameters.AddWithValue("@password", password);
            adapter.SelectCommand = com;
            adapter.Fill(table);
            try
            {
                com.ExecuteNonQuery();
                MessageBox.Show("Запись не обновлена");
            }
            catch
            {
                MessageBox.Show("Запись обновлена");
            }



        }


        //удаление строк
        private void class13_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            db db = new db();
             DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand com = new MySqlCommand("DELETE FROM `users` WHERE ID = @id", db.getConnection()) ;
            com.Parameters.AddWithValue("@id", id);
            adapter.SelectCommand = com;
            adapter.Fill(table);
            try
            {
                com.ExecuteNonQuery();
                MessageBox.Show("Запись не удалена");
            }
            catch
            {
                MessageBox.Show("Запись удалена");
            }
        }

        private void class14_Click(object sender, EventArgs e)
        {

            string login = textBox2.Text;
            string password = textBox3.Text;
            db db = new db();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand com = new MySqlCommand("INSERT INTO `users`(`login`, `password`) VALUES (@login, @password )", db.getConnection());
            com.Parameters.AddWithValue("@login", login);
            com.Parameters.AddWithValue("@password", password);
            adapter.SelectCommand = com;
            adapter.Fill(table);
            try
            {
                com.ExecuteNonQuery();
                MessageBox.Show("Запись не добавлена");
            }
            catch
            {
                MessageBox.Show("Запись добавлена");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void class15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

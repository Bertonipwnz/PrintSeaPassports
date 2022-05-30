using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Registr : MaterialForm
    {
        public Registr()
        {
            InitializeComponent();
            
        }

        private void class11_Click(object sender, EventArgs e)
        {
            //форма авторизации
            string loginUser = loginField.Text;
            string passUser = passwordField.Text;
            string nowTime = DateTime.Now.ToString("HH:mm:ss dd MMMM yyyy");
            //подключение базы данных;
            db db = new db();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            //выборка данных
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP" ,  db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            //проверка на наличие данных
            if (table.Rows.Count > 0)
            {
                //проверка на администратора
                if (loginUser == "admin" && passUser == "admin")
                {
                    this.Hide();
                    MessageBox.Show("Добро пожаловать в панель администратора");
                    adminpanel newForm1 = new adminpanel();
                    newForm1.Show();
                }
                //проверка на сотрудника
                else
                {
                    this.Hide();
                    MessageBox.Show("Вы успешно вошли");
                    mainForm newForm = new mainForm();
                    newForm.Show();

                }

            }
            else
                MessageBox.Show("Такой пользователь не найден в системе");
            //добавление в базу логов данных пользователя
            MySqlCommand command2 = new MySqlCommand("INSERT INTO `log`(`login`, `Data`) VALUES (@uL2, @dT)", db.getConnection());
            command2.Parameters.Add("@uL2", MySqlDbType.VarChar).Value = loginUser;
            command2.Parameters.Add("@dT", MySqlDbType.VarChar).Value = nowTime;
            adapter.SelectCommand = command2;


            adapter.Fill(table);
        
            


            
        }

        private void loginField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

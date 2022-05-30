using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace WindowsFormsApp1
{
    public partial class Form3 : MaterialForm
    {
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(mainForm f)
        {
            InitializeComponent();
            f.BackColor = Color.Yellow;
        }
        #region RUS
        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion RUS
        private void button2_Click(object sender, EventArgs e)
        {
            //RUS
            string positRUS, NameVesselRUS, ShipOwnerRUS, TypeVesselRUS, PortRegistryRUS, GrossTonnageRUS, TypeKWRUS, SealRUS;
            positRUS = textBox16.Text; //должность  
            NameVesselRUS = textBox15.Text; // название, национальность, ИМО номер судна
            ShipOwnerRUS = textBox14.Text; //судовладелец
            TypeVesselRUS = textBox13.Text; //тип судна
            PortRegistryRUS = textBox12.Text; //порт регистрации
            GrossTonnageRUS = textBox11.Text; // валовая вместимость
            TypeKWRUS = textBox10.Text; // тип марка мощность двигателя кВт
            SealRUS = richTextBox2.Text; //МП должность, фамилия
            #region ENGx
            //ENG
            string positENG, NameVesselENG, ShipOwnerENG, TypeVesselENG, PortRegistryENG, GrossTonnageENG, TypeKWENG, SealENG;
            positENG = textBox7.Text; 
            NameVesselENG = textBox6.Text; 
            ShipOwnerENG = textBox5.Text; 
            TypeVesselENG = textBox4.Text; 
            PortRegistryENG = textBox3.Text; 
            GrossTonnageENG = textBox2.Text;
            TypeKWENG = textBox1.Text; 
            SealENG = richTextBox1.Text;
            #endregion ENDx
            #region PeredachaVword
            //Создаём объект документа
            Word.Document doc = null;
            try
            {
                //Создаём объект приложения
                Word.Application app = new Word.Application();
                //Путь до шаблона документа
                //  string source = @"C:\Users\User\Desktop\с#\Новая папка (2)\MK_2_Zam.doc";
                string filename = "MK_2_Zam";
                string fullPath;
                fullPath = Path.GetFullPath(filename);
                string source = fullPath;
                //Открываем
                doc = app.Documents.Open(source);
                doc.Activate();

                //Добавление информации
                Word.Bookmarks wBookmarks = doc.Bookmarks;
                Word.Range wRange;
                int i = 0;
                string[] data = new string[16] { positRUS, NameVesselRUS, ShipOwnerRUS, TypeVesselRUS, PortRegistryRUS, GrossTonnageRUS, TypeKWRUS, SealRUS, positENG, NameVesselENG, ShipOwnerENG, TypeVesselENG, PortRegistryENG, GrossTonnageENG, TypeKWENG, SealENG };
                foreach (Word.Bookmark mark in wBookmarks)
                {
                    wRange = mark.Range;
                    wRange.Text = data[i];
                    i++;
                }
                doc.Close();
                doc = null;
                app.Quit();
            }
            catch
            {
                doc.Close();
                doc = null;
                Console.WriteLine("Произошла ошибка");
                Console.ReadLine();

            }
            #endregion PeredachaVword

            db db = new db();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("INSERT INTO table2(positRUS, NameVesselRUS, ShipOwnerRUS, TypeVersselRUS, PortRegistryRUS, GrossTonnageRUS, TypeKWRUS, SealRUS)  VALUES (@positRUS, @NameVesselRUS, @ShipOwnerRUS, @TypeVesselRUS, @PortRegistryRUS, @GrossTonnageRUS, @TypeKWRUS, @SealRUS)", db.getConnection());
            command.Parameters.AddWithValue("positRUS", textBox16.Text);
            command.Parameters.AddWithValue("NameVesselRUS", textBox15.Text);
            command.Parameters.AddWithValue("ShipOwnerRUS", textBox14.Text);
            command.Parameters.AddWithValue("TypeVesselRUS", textBox13.Text);
            command.Parameters.AddWithValue("PortRegistryRUS", textBox12.Text);
            command.Parameters.AddWithValue("GrossTonnageRUS", textBox11.Text);
            command.Parameters.AddWithValue("TypeKWRUS", textBox10.Text);
            command.Parameters.AddWithValue("SealRUS", richTextBox2.Text);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Yes");
            }
            else
                MessageBox.Show("Данные внесены в базу данных и документ Word");
        }
        #region ENG
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion ENG

    

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.Copy(@"копии\MK_2_Zam.doc", @"MK_2_Zam.doc", true);
            MessageBox.Show("Документ очищен");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Word.Application app = new Word.Application();
            string filename = "MK_Ruk.doc";
            string fullPath;
            fullPath = Path.GetFullPath(filename);
            string source = fullPath;
            app.Documents.Open(source);
            // Обрабатываю файл
            app.ActiveDocument.Save();
            app.Dialogs[Word.WdWordDialog.wdDialogFilePrint].Show();
            app.ActiveDocument.Close();
            app.Visible = false;
            app.Quit();
        }
    }
    }


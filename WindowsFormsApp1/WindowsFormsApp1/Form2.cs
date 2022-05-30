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
using Word = Microsoft.Office.Interop.Word;

namespace WindowsFormsApp1
{
    public partial class Form2 : MaterialForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(mainForm f)
        {
            InitializeComponent();
            f.BackColor = Color.Green;
        }

      //обработка передачи данных в ворд
        private void button1_Click(object sender, EventArgs e)
        {
            string codegos, numberdoc, surname, givennames, nationality, dateofbirth, placeofbir, sexx, dateofissue, OfPosNameSign;
            label1.Text = string.Format(monthCalendar1.SelectionStart.ToLongDateString()); //считывание параметров календаря
            label2.Text = string.Format(monthCalendar2.SelectionStart.ToLongDateString()); //считывание параметров календаря
            string sItem = System.Convert.ToString(listBox1.SelectedItem);
            codegos = textBox1.Text; //код государства
            numberdoc = textBox2.Text; // номер документа
            surname = textBox3.Text; //фамилия
            givennames = textBox4.Text; //имя отчество
            nationality = textBox6.Text; //гражданство
            dateofbirth = label2.Text; // Дата рождения
            placeofbir = textBox8.Text; // место рождения
            sexx = sItem; // пол
            dateofissue = label1.Text; //дата выдачи
            OfPosNameSign = richTextBox1.Text; //позиция, нейм
            // заполнение ворда
            string dabl = codegos + " " + " " + " " + " " + " " + " " + numberdoc;
                //Создаём объект документа
            Word.Document doc = null;
                try
                {
                    //Создаём объект приложения
                    Word.Application app = new Word.Application();
                //Путь до шаблона документа
               // string source = @"MK_Ruk.doc";
                string filename = "MK_Ruk.doc";
                string fullPath;
                fullPath = Path.GetFullPath(filename);
                string source = fullPath;
                //MessageBox.Show(fullPath);
                    //Открываем
                    doc = app.Documents.Open(source);
                    doc.Activate();

                    //Добавление информации
                    Word.Bookmarks wBookmarks = doc.Bookmarks;
                    Word.Range wRange;
                    int i = 0;
                    string[] data = new string[9] { dabl, surname, givennames, nationality, dateofbirth, placeofbir, sexx, dateofissue, OfPosNameSign };
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
            
            // System.Diagnostics.Process.Start(@"MK_Ruk.doc");
db db = new db(); //вызов класса для подключения БД
DataTable table = new DataTable(); //создание объекта для формирования таблиц
MySqlDataAdapter adapter = new MySqlDataAdapter(); //создание объекта для хранения промежуточной информации
//запрос на внесение данных в mysql
MySqlCommand command = new MySqlCommand("INSERT INTO `table1`(`codegos`, `numberdoc`, `surname`, `givennames`, `nationality`, " +
"`dateofbirth`, `placeofbir`, `sexx`, `dateofissue`, `OfPosNameSign`) " +
"VALUES (@codegos, @numberdoc, @surname, @givennames, @nationality, " +
"@dateofbirth, @placeofbir, @sexx, @dateofissue, @OfPosNameSign )", db.getConnection());
 //запись данных из полей формы в переменные
command.Parameters.AddWithValue("codegos", textBox1.Text);
command.Parameters.AddWithValue("numberdoc", textBox2.Text);
command.Parameters.AddWithValue("surname", textBox3.Text);
command.Parameters.AddWithValue("givennames", textBox4.Text);
command.Parameters.AddWithValue("nationality", textBox6.Text);
command.Parameters.AddWithValue("dateofbirth", label2.Text);
command.Parameters.AddWithValue("placeofbir", textBox8.Text);
command.Parameters.AddWithValue("sexx", sItem);
command.Parameters.AddWithValue("dateofissue", label1.Text);
command.Parameters.AddWithValue("OfPosNameSign", richTextBox1.Text);
//присвоение адаптеру параметров из command
adapter.SelectCommand = command;
//обновление таблицы
adapter.Fill(table);
//проверка внесены данные или нет
if (table.Rows.Count > 0)
{
MessageBox.Show("Yes");
}
else
MessageBox.Show("Данные внесены в базу данных и документ Word");
}
        #region gg
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        #endregion gg
  
        private void button3_Click(object sender, EventArgs e)
        {
           
            File.Copy(@"копии\MK_Ruk.doc", @"MK_Ruk.doc", true);
            MessageBox.Show("Документ очищен");
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
         
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         

            

        }

        private void button2_Click(object sender, EventArgs e)
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


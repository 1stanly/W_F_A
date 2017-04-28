using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace W_F_A
{
    public partial class Form1 : Form
    {
        SaveFile saveFile = new SaveFile();
        int numberJournalAndLiterature=5;
        int numberNewspaperLiterature = 3;
        string strAll=" ";

        public string tb;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ShowLibrary();
        }
        public void ShowLibrary()
        {
            listBox1.Items.Add("BOOKS");
            for(int i = 0; i < numberJournalAndLiterature; i++)
            {
                listBox1.Items.Add("name - " + Library.bookNames[i] + "***" + "book years - " + Library.bookYears[i] + "***" + "book authors - " + Library.bookAuthors[i] + "***" + "book number - " + Library.bookNumber[i]);
            }
            listBox1.Items.Add("");

            listBox1.Items.Add("JOURNALS");
            for(int i=0;i< numberJournalAndLiterature; i++)
            {
                listBox1.Items.Add("name - " + Library.ListJournalNames[i]+ "***" + "numberEdition - "+Library.ListJournalNumberEdition[i]+"***"+"article - "+Library.listJournalArticles[i].Name+ "***" + "author - "+Library.listJournalArticles[i].Author+ "***"+"numberOfPages - " +Library.ListJournalNumberOfPages[i]);             
            }
            listBox1.Items.Add("");
            listBox1.Items.Add("NEWSPAPERS");
            for (int i = 0; i < numberNewspaperLiterature; i++)
            {
                listBox1.Items.Add("name - " + Library.ListNewspaperNames[i] + "***" + "numberEdition - " + Library.ListNewspaperRating[i] + "***" + "article - " + Library.listNewspaperArticles[i].Name + "***" + "author - " + Library.listNewspaperArticles[i].Author + "***" + "numberOfPages - " + Library.ListNewspaperNumberOfPages[i]);
            }
        }
        public void CheckEnterWords()
        {
            tb = textBox1.Text;
            for (int i = 0; i < Library.bookAuthors.Count; i++)
            {
                if (Library.bookAuthors[i].Contains(tb))
                {
                    strAll += Library.bookNames[i]+" ";
                }
            }   
            for (int i = 0; i < Library.listJournalArticles.Count; i++)
            {
                if (Library.listJournalArticles[i].Author.Contains(tb))
                {
                    strAll += Library.ListJournalNames[i]+ " ";                   
                }
            }
            for (int i = 0; i < Library.listNewspaperArticles.Count; i++)
            {
                if (Library.listNewspaperArticles[i].Author.Contains(tb))
                {
                    strAll += " " + Library.ListNewspaperNames[i];
                }
            }
            if (strAll != " ")
            {
                listBox2.Items.Add(strAll);
            }
            else
            {
                listBox2.Items.Add("Author not find");
            }
            strAll = " ";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CheckEnterWords();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            saveFile.Save(listBox1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ////Создание открытого подключения
            //string connectionStr = @"Data Source=Alexey-ПК\SQLEXPRESS;Initial Catalog=Test;Integrated Security=SSPI;";
            //SqlConnection dbConnection = new SqlConnection(connectionStr);
            //dbConnection.Open();

            ////Создание обьекта команды SQL
            //string sqlQuery = "INSERT INTO Friends (name, age,job) VALUES ('Имя',18,'Vriver')"; //-добавляем в табличку baza строку с значением поля fio равным 'Имя', а поля tel равным 'Телефон'
            //using (SqlCommand command = new SqlCommand(sqlQuery, dbConnection))
            //{
            //    //Отправляем команду
            //    command.ExecuteNonQuery();
            //    this.friendsTableAdapter.Fill(this.testDataSet.Friends);

            //}

            ////Закрываем соединение с базой данных

        }
    }
}
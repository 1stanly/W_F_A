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

namespace W_F_A
{
    public partial class Form1 : Form
    {
        Library lib = new Library();
        string tb;
        string strMassAuthors;
        string strMassArticle;
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
            int x = 0;
            int y = 0;
            int z = 0;
            tb = textBox1.Text;
            foreach (BookTemplate j in Library.listBooks)
            {
                foreach (string h in Library.arrAuthors[x])
                {
                    strMassAuthors += h + " ";
                }
                listBox1.Items.Add("book - " + j.Book + ";  year - " + j.Year + ";  number - " + j.Number + ";  author - " + strMassAuthors);
                strMassAuthors = "";
                x++;
            }
            listBox1.Items.Add("");
            foreach (JournalTemplate j in Library.listJournals)
            {
                foreach (string h in Library.arrAuthors[x])
                {
                    strMassAuthors += h + " ";
                }
                foreach (string h in Library.arrArticles[y])
                {
                    strMassArticle += h + " ";
                }
                listBox1.Items.Add("journal - " + j.Journal + "; number edition - " + j.NumberEdition + "; number of pages - " + j.NumberOfPages + "; article - " + strMassArticle + "; author - " + strMassAuthors);
                strMassAuthors = "";
                strMassArticle = "";
                x++;
                y++;
            }
            listBox1.Items.Add("");
            foreach (NewspaperTemplate j in Library.listNewspapers)
            {
                foreach (string h in Library.arrAuthors[x])
                {
                    strMassAuthors += h + " ";
                }
                foreach (string h in Library.arrArticles[z])
                {
                    strMassArticle += h + " ";
                }
                listBox1.Items.Add("nuwspaper - " + j.Newspaper + "; rating - " + j.Rating + "; number of pages - " + j.NumberOfPages + "; article - " + strMassArticle + "; author - " + strMassAuthors);
                strMassAuthors = "";
                strMassArticle = "";
                x++;
                y++;
                z++;
            }
        }
        public void CheckEnterWords()
        {
            for (int i = 0; i < Library.arrAuthors.Count; i++)
            {
                for (int j = 0; j < Library.arrAuthors[i].Count; j++)
                {
                    if (Library.arrAuthors[i][j] == textBox1.Text)
                    {
                        listBox2.Items.Add(Library.listBooks[i].Book);
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CheckEnterWords();
        }
        //private void button3_Click(object sender, EventArgs e)
        //{
        //    SaveFileDialog save = new SaveFileDialog();
        //    save.Filter = "Text documents (.txt)|*.txt";

        //    if (save.ShowDialog() == DialogResult.OK)
        //    {
        //        StreamWriter w = new StreamWriter(save.FileName);

        //        foreach (var item in listBox1.Items)
        //            w.WriteLine(item.ToString());

        //        w.Close();
        //    }
        //}
    }
}

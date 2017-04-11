using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W_F_A
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Library lib = new Library();
            lib.CreateMassAuthors();
            lib.CreateMassArticles();

            lib.CreateListBooks();
            lib.CreateListJournals();
            lib.CreateListNewspapers();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

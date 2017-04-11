using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace W_F_A
{
    public class Library
    {
        static public List<BookTemplate> listBooks = new List<BookTemplate>();
        static public List<JournalTemplate> listJournals = new List<JournalTemplate>();
        static public List<NewspaperTemplate> listNewspapers = new List<NewspaperTemplate>();
        static public List<string> arrArticlesJournals = new List<string>();
        static public List<string> arrArticlesNewspapers = new List<string>();

        static public List<string> arrBookAuthors1 = new List<string> { "Pushkin", "Lermontov", "Tolstoi", "Gogol" };
        static public List<string> arrBookAuthors2 = new List<string> { "Petrov", "Sidorov", "Bah" };
        static public List<string> arrBookAuthors3 = new List<string> { "Stepan", "Grigoryi", "Picaso" };
        static public List<string> arrBookAuthors4 = new List<string> { "DJ_Vasia", "Pavlik" };
        static public List<string> arrBookAuthors5 = new List<string> { "Shekspir", "Bah" };

        static public List<string> arrJournalAuthors1 = new List<string> { "Givi", "Chukcha" };
        static public List<string> arrJournalAuthors2 = new List<string> { "Groznyi", "Alibaba" };
        static public List<string> arrJournalAuthors3 = new List<string> { "Jakson" };
        static public List<string> arrJournalAuthors4 = new List<string> { "Braun", "Bob", "Chehov" };
        static public List<string> arrJournalAuthors5 = new List<string> { "Bulgakov" };

        static public List<string> arrNewspaperAuthors1 = new List<string> { "Cris" };
        static public List<string> arrNewspaperAuthors2 = new List<string> { "Putin" };
        static public List<string> arrNewspaperAuthors3 = new List<string> { "Jane", "Richards" };

        static public List<string> arrJournalArticles1 = new List<string> { "Home & Garden", "Extream" };
        static public List<string> arrJournalArticles2 = new List<string> { "Agriculture" };
        static public List<string> arrJournalArticles3 = new List<string> { "Policy", };
        static public List<string> arrJournalArticles4 = new List<string> { "Health" };
        static public List<string> arrJournalArticles5 = new List<string> { "Sport", "News" };

        static public List<string> arrNewspaperArticles1 = new List<string> { "Cooking", "Travel" };
        static public List<string> arrNewspaperArticles2 = new List<string> { "entertainment" };
        static public List<string> arrNewspaperArticles3 = new List<string> { "Auto", "Moto" };

        static public List<List<string>> arrAuthors = new List<List<string>>();
        static public List<List<string>> arrArticles = new List<List<string>>();

        public void CreateMassAuthors()
        {
            arrAuthors.Add(arrBookAuthors1);
            arrAuthors.Add(arrBookAuthors2);
            arrAuthors.Add(arrBookAuthors3);
            arrAuthors.Add(arrBookAuthors4);
            arrAuthors.Add(arrBookAuthors5);

            arrAuthors.Add(arrJournalAuthors1);
            arrAuthors.Add(arrJournalAuthors2);
            arrAuthors.Add(arrJournalAuthors3);
            arrAuthors.Add(arrJournalAuthors4);
            arrAuthors.Add(arrJournalAuthors5);

            arrAuthors.Add(arrNewspaperAuthors1);
            arrAuthors.Add(arrNewspaperAuthors2);
            arrAuthors.Add(arrNewspaperAuthors3);
        }
        public void CreateMassArticles()
        {
            arrArticles.Add(arrJournalArticles1);
            arrArticles.Add(arrJournalArticles2);
            arrArticles.Add(arrJournalArticles3);
            arrArticles.Add(arrJournalArticles4);
            arrArticles.Add(arrJournalArticles5);

            arrArticles.Add(arrNewspaperArticles1);
            arrArticles.Add(arrNewspaperArticles2);
            arrArticles.Add(arrNewspaperArticles3);
        }
        public void CreateListBooks()
        {
            listBooks.Add(new BookTemplate() { Book = "Master i Margo", Year = "1891", Number = "1000" });
            listBooks.Add(new BookTemplate() { Book = "Voina i Mir", Year = "1865", Number = "835" });
            listBooks.Add(new BookTemplate() { Book = "Mertvye Dushi", Year = "1842", Number = "933" });
            listBooks.Add(new BookTemplate() { Book = "Evgenyi Onegin", Year = "1825", Number = "1114" });
            listBooks.Add(new BookTemplate() { Book = "Palata №6", Year = "1892", Number = "753", });
        }
        public void CreateListJournals()
        {
            listJournals.Add(new JournalTemplate() { Journal = "Cosmopolitan", NumberEdition = "№ 147", NumberOfPages = "25"});
            listJournals.Add(new JournalTemplate() { Journal = "Vogue", NumberEdition = "№ 45", NumberOfPages = "63"});
            listJournals.Add(new JournalTemplate() { Journal = "GQ ", NumberEdition = "№ 96", NumberOfPages = "15" });
            listJournals.Add(new JournalTemplate() { Journal = "Vanity Fair ", NumberEdition = "№ 521", NumberOfPages = "42" });
            listJournals.Add(new JournalTemplate() { Journal = "Marie Claire ", NumberEdition = "№ 313", NumberOfPages = "28" });

        }
        public void CreateListNewspapers()
        {
            listNewspapers.Add(new NewspaperTemplate() { Newspaper = "The New Yourk Times", Rating = "65 %", NumberOfPages = "42" });
            listNewspapers.Add(new NewspaperTemplate() { Newspaper = "The Wall Street Journal", Rating = "48 %", NumberOfPages = "53" });
            listNewspapers.Add(new NewspaperTemplate() { Newspaper = "Los Angeles Times", Rating = "39 %", NumberOfPages = "37" });
        }
    }
}

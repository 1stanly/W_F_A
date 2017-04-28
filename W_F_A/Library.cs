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
        public static List<Article> listJournalArticles = new List<Article>();
        public static List<Article> listNewspaperArticles = new List<Article>();

        public static List<string> bookNames = new List<string> { "Master i Margo", "Voina i Mir", "Mertvye Dushi", "Evgenyi Onegin", "Palata №6" };
        public static List<string> bookYears = new List<string>() { "1867", "1954", "1971", "1786", "1752" };
        public static List<string> bookAuthors = new List<string>() { "Pushkin,Bah, Lermontov,Tolstoi", "Bah", "DJ_Vasia,Pavlik", "Figaro,Bah", "Zombak, Topak" };
        public static List<string> bookNumber = new List<string>() { "35", "41", "23", "16", "26" };

        public static List<string> ListJournalNames = new List<string> { "Cosmopolitan", "Vogue", "GQ ", "Vanity Fair ", "Marie Claire " };
        public static List<string> ListJournalNumberEdition = new List<string> { "№251", "№645", "№54", "№235", "432 " };
        public static List<string> ListJournalNumberOfPages = new List<string> { "34", "23", "19 ", "43 ", "41 " };

        public static List<string> ListNewspaperNames = new List<string> { "The New Yourk Times", "The Wall Street Journal", "Los Angeles Times" };
        public static List<string> ListNewspaperRating = new List<string> { "36 %", "47 %", "28 %", };
        public static List<string> ListNewspaperNumberOfPages = new List<string> { "212", "54", "122" };

        public void CreateJournalArticles()
        {
            listJournalArticles.Add(new Article() { Name = "Home", Author = "Gosha,Kostia,Kris" });
            listJournalArticles.Add(new Article() { Name = "Extream, News", Author = "Vania" });
            listJournalArticles.Add(new Article() { Name = "Agriculture", Author = "Masha,Sasha" });
            listJournalArticles.Add(new Article() { Name = "Policy, Sport", Author = "Roma,Kris" });
            listJournalArticles.Add(new Article() { Name = "Health", Author = "Jorge,Kris,Bah" });
        }
        public void CreateNewspaperArticles()
        {
            listNewspaperArticles.Add(new Article() { Name = "Sport,News", Author = "King" });
            listNewspaperArticles.Add(new Article() { Name = "Cooking,Policy", Author = "Petro, Shumaher" });
            listNewspaperArticles.Add(new Article() { Name = "Auto,Moto", Author = "Abama, King" });
        }
    }
}


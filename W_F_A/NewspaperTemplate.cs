using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W_F_A
{
   public class NewspaperTemplate
    {
        public string Newspaper { get; set; }
        public string Rating { get; internal set; }
        public string NumberOfPages { get; set; }
        public string Article { get; set; }
        public string Author { get; set; }
    }
}

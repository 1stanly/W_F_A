using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace W_F_A
{
   public partial class SaveFile:Form
    {
        public void Save()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text documents (.txt)|*.txt";

            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter w = new StreamWriter(save.FileName);

                foreach (var item in listBox1.Items)
                    w.WriteLine(item.ToString());

                w.Close();
            }
        }
}
}

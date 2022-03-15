using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlocDeNotas
{
    public partial class NoteBook : Form
    {
        public NoteBook()
        {
            InitializeComponent();
        }

        #region Buttons Edit

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbInformation.Copy();
        }

        private void pasteçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbInformation.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbInformation.SelectAll();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbInformation.Clear();
        }


        #endregion


        #region Buttons File

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbInformation.Clear();

        }




        #endregion

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            System.IO.StringReader open = new System.IO.StringReader(openFileDialog1.FileName);

            rtbInformation.Text = open.ReadToEnd();

            open.Close();
         }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();

            System.IO.StreamWriter save = new System.IO.StreamWriter(saveFileDialog1.FileName);

            save.WriteLine(rtbInformation.Text);

            save.Close();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveas = new SaveFileDialog();

            System.IO.StreamReader mystream = null;
            saveas.Filter = "Text (* .txt) |*.txt[HTML(*.html*)] | *.html|All file(*.*)|*.*)";
            saveas.CheckFileExists = true;
            saveas.Title = "Guardar Como";
            saveas.ShowDialog(this);

            try {

                mystream = System.IO.File.OpenText(saveas.FileName);
               
            }
            catch {
            }

        }
    }
}

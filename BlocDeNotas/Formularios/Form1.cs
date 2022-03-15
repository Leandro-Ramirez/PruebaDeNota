#region Usos
using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
#endregion

namespace BlocDeNotas
{
    public partial class NoteBook : Form
    {
        #region Inicializar componente NoteBook
        public NoteBook()
        {
            InitializeComponent();
        }
        #endregion

        #region Botones Editar
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

        #region Botones de Archivo
        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbInformation.Clear();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            Proceso1();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proceso2();
        }
        #endregion

        #region Metodo
        public void Proceso1()
        {
            openFileDialog1.ShowDialog();

            System.IO.StringReader open = new System.IO.StringReader(openFileDialog1.FileName);

            rtbInformation.Text = open.ReadToEnd();

            open.Close();
        }

        public void Proceso2()
        {
            saveFileDialog1.ShowDialog();

            System.IO.StreamWriter save = new System.IO.StreamWriter(saveFileDialog1.FileName);

            save.WriteLine(rtbInformation.Text);

            save.Close();
        }
        #endregion
        
    }
}

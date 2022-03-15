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
using System.IO;
#endregion

namespace BlocDeNotas
{
    public partial class NoteBook : Form
    {
        #region Variable Global
        List<string> listaNotas = new List<string>();
        string rutaTreeView;
        #endregion

        #region Inicializar componente NoteBook
        public NoteBook()
        {
            InitializeComponent();
            NodosTvArbol();
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
            AbrirArchivo();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarComo();
        }
        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salir();
        }
        #endregion

        #region Metodo
        public void AbrirArchivo()
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "All Filter (*.txt) | *.txt";

            if(open.ShowDialog() == DialogResult.OK)
            {
                rtbInformation.Text = File.ReadAllText(open.FileName); 
            }
        }

        public void GuardarComo()
        {
            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "Archivos de Texto (*.txt) | *.txt";

            if (save.ShowDialog() == DialogResult.OK)
            {
                rtbInformation.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        public void Guardar()
        {
            SaveFileDialog saveas = new SaveFileDialog();
            StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName);

            saveas.Filter = "Archivos de Texto (*.txt) | *.txt ";
            saveas.CheckFileExists = true;
            saveas.Title = "Guardar Como";
            saveas.ShowDialog(this);

            try
            {
                streamWriter = File.AppendText(saveas.Filter);
                streamWriter.Write(rtbInformation.Text);
                streamWriter.Flush();
            }
            catch
            {
            }
        }

        public void Salir()
        {
            DialogResult result = MessageBox.Show("Esta seguro de querer salir?", "Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion

        #region Extras
        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        #endregion

        #region Botones Del Arbol
        
        //XD
        private void agregarCarpetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TvArbol.Nodes.Add(TxtCarpeta.Text);
            TxtCarpeta.Text = " ";
        }
        private void agregarElementoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TvArbol.SelectedNode.Nodes.Add(TxtNombre.Text);
            TxtNombre.Text = " ";
        }
        private void eliminarElementoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TvArbol.Nodes.Remove(TvArbol.SelectedNode);
        }
        #endregion

        #region Otros
        //Codigo del Video de 28 Minutos
        private void NodosTvArbol()
        {
            TreeNode NodoSistem;
            DirectoryInfo ruta = new DirectoryInfo("C:\\Jadppa");
            if (ruta.Exists)
            {
                NodoSistem = new TreeNode(ruta.Name);
                NodoSistem.Tag = ruta;
                GetDirectories(ruta.GetDirectories(), NodoSistem);
                TvArbol.Nodes.Add(NodoSistem);
            }
        }
        private void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            TreeNode ANode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                ANode = new TreeNode(subDir.Name, 0, 0);
                ANode.Tag = subDir;
                ANode.ImageKey = "Folder";
                subSubDirs = subDir.GetDirectories();

                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, ANode);
                }
                nodeToAddTo.Nodes.Add(ANode);
            }
        }

        private void TvArbol_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            {
                TreeNode newSelected = e.Node;
                listView1.Items.Clear();
                DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
                ListViewItem.ListViewSubItem[] subItems;
                ListViewItem item = null;

                foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
                {
                    item = new ListViewItem(dir.Name, 0);
                    subItems = new ListViewItem.ListViewSubItem[]
                    {
                        new ListViewItem.ListViewSubItem (item, "Directory"),
                        new ListViewItem.ListViewSubItem (item,
                            dir.LastWriteTime.ToShortDateString())
                    };
                    item.SubItems.AddRange(subItems);
                    listView1.Items.Add(item);
                }

                foreach (FileInfo file in nodeDirInfo.GetFiles())
                {
                    item = new ListViewItem(file.Name, 1);
                    subItems = new ListViewItem.ListViewSubItem[]
                        {
                            new ListViewItem.ListViewSubItem (item,"File"),
                            new ListViewItem.ListViewSubItem(item,file.LastAccessTime.ToShortDateString())
                        };
                    item.SubItems.AddRange(subItems);
                    listView1.Items.Add(item);


                }
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        //Codigo de Jasser (Casi adaptado)
        private void LoadFolder(TreeNodeCollection nodes, DirectoryInfo folder)
        {
            var newNode = nodes.Add(folder.Name);
            foreach (var childFolder in folder.EnumerateDirectories())
            {
                LoadFolder(newNode.Nodes, childFolder);
            }
            foreach (FileInfo file in folder.EnumerateFiles())
            {
                newNode.Nodes.Add(file.Name);
            }
            //TvArbol.ImageList = imageList1;
            TvArbol.ImageIndex = 1;
            TvArbol.Nodes[0].ImageIndex = 0;
            TvArbol.SelectedImageIndex = 1;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoteBook_Load(sender, e);

            string rutaArchivo = string.Empty;
            string filePath = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = openFileDialog.FileName;
                rutaTreeView = Path.GetDirectoryName(@rutaArchivo);
                filePath = Path.GetDirectoryName(rutaArchivo);

                LoadFolder(TvArbol.Nodes, new DirectoryInfo(@filePath));
                rtbInformation.Text = notasServices.Read(@rutaArchivo);
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoteBook_Load(sender, e);

            string rutaArchivo = string.Empty;
            string filePath = string.Empty;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = saveFileDialog.FileName;
                rutaTreeView = Path.GetDirectoryName(@rutaArchivo);
                filePath = Path.GetDirectoryName(rutaArchivo);
                notasServices.Create(rtbInformation.Text, rutaArchivo);
                LoadFolder(TvArbol.Nodes, new DirectoryInfo(@filePath));
            }
        }
        private void TvArbol_DoubleClick(object sender, EventArgs e)
        {
            string rutaAbsoluta = string.Empty;
            rutaAbsoluta = rutaTreeView + "\\" + TvArbol.SelectedNode.Text;
            rtbInformation.Text = notasServices.Read(@rutaAbsoluta);
        }
        private void NoteBook_Load(object sender, EventArgs e)
        {
            TvArbol.Nodes.Clear();
        }
        #endregion
    }
}
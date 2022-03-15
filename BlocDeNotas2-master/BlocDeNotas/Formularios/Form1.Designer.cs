
namespace BlocDeNotas
{
    partial class NoteBook
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editThingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.rtbInformation = new System.Windows.Forms.RichTextBox();
            this.TvArbol = new System.Windows.Forms.TreeView();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCarpetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarElementoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarElementoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCarpeta = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editThingsToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(860, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.fileToolStripMenuItem.Text = "Archivo";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.FileToolStripMenuItem_Click);
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.newFileToolStripMenuItem.Text = "Nuevo Archivo";
            this.newFileToolStripMenuItem.Click += new System.EventHandler(this.newFileToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.openFileToolStripMenuItem.Text = "Abrir Archivo";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.saveToolStripMenuItem.Text = "Guardar Como...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.ShowShortcutKeys = false;
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.exitToolStripMenuItem.Text = "Salir";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // editThingsToolStripMenuItem
            // 
            this.editThingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteçToolStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.editThingsToolStripMenuItem.Name = "editThingsToolStripMenuItem";
            this.editThingsToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.editThingsToolStripMenuItem.Text = "Edit things";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.copyToolStripMenuItem.Text = "Copiar";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteçToolStripMenuItem
            // 
            this.pasteçToolStripMenuItem.Name = "pasteçToolStripMenuItem";
            this.pasteçToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.pasteçToolStripMenuItem.Text = "Pegar";
            this.pasteçToolStripMenuItem.Click += new System.EventHandler(this.pasteçToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.selectAllToolStripMenuItem.Text = "Seleccionar Todo";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.clearToolStripMenuItem.Text = "Limpiar";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // rtbInformation
            // 
            this.rtbInformation.Location = new System.Drawing.Point(149, 53);
            this.rtbInformation.Name = "rtbInformation";
            this.rtbInformation.Size = new System.Drawing.Size(600, 400);
            this.rtbInformation.TabIndex = 1;
            this.rtbInformation.Text = "";
            // 
            // TvArbol
            // 
            this.TvArbol.Location = new System.Drawing.Point(13, 53);
            this.TvArbol.Name = "TvArbol";
            this.TvArbol.Size = new System.Drawing.Size(130, 400);
            this.TvArbol.TabIndex = 2;
            this.TvArbol.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TvArbol_NodeMouseDoubleClick);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCarpetaToolStripMenuItem,
            this.agregarElementoToolStripMenuItem,
            this.eliminarElementoToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Arbol";
            // 
            // agregarCarpetaToolStripMenuItem
            // 
            this.agregarCarpetaToolStripMenuItem.Name = "agregarCarpetaToolStripMenuItem";
            this.agregarCarpetaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarCarpetaToolStripMenuItem.Text = "Agregar Carpeta";
            this.agregarCarpetaToolStripMenuItem.Click += new System.EventHandler(this.agregarCarpetaToolStripMenuItem_Click);
            // 
            // agregarElementoToolStripMenuItem
            // 
            this.agregarElementoToolStripMenuItem.Name = "agregarElementoToolStripMenuItem";
            this.agregarElementoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarElementoToolStripMenuItem.Text = "Agregar Elemento";
            this.agregarElementoToolStripMenuItem.Click += new System.EventHandler(this.agregarElementoToolStripMenuItem_Click);
            // 
            // eliminarElementoToolStripMenuItem
            // 
            this.eliminarElementoToolStripMenuItem.Name = "eliminarElementoToolStripMenuItem";
            this.eliminarElementoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarElementoToolStripMenuItem.Text = "Eliminar Elemento";
            this.eliminarElementoToolStripMenuItem.Click += new System.EventHandler(this.eliminarElementoToolStripMenuItem_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(149, 27);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtNombre.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Titulo del Texto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre de la Carpeta:";
            // 
            // TxtCarpeta
            // 
            this.TxtCarpeta.Location = new System.Drawing.Point(414, 27);
            this.TxtCarpeta.Name = "TxtCarpeta";
            this.TxtCarpeta.Size = new System.Drawing.Size(100, 20);
            this.TxtCarpeta.TabIndex = 5;
            // 
            // NoteBook
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(860, 545);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCarpeta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TvArbol);
            this.Controls.Add(this.rtbInformation);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NoteBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoteBook -- SaidRivas & Leandro Ramirez";
            this.Load += new System.EventHandler(this.NoteBook_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editThingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteçToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox rtbInformation;
        private System.Windows.Forms.TreeView TvArbol;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agregarCarpetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarElementoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarElementoToolStripMenuItem;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCarpeta;
    }
}


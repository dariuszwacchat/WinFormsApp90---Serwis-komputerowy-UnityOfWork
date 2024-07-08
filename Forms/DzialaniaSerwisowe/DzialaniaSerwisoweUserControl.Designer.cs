
namespace WinFormsApp90.Forms.DzialaniaSerwisowe
{
    partial class DzialaniaSerwisoweUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DzialaniaSerwisoweUserControl));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewDzialaniaSerwisowe = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip14 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDodajDzialanieSerwisowe = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUsunDzialanieSerwisowe = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonModyfikujDzialanieSerwisowe = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBoxFirmyDzialaniaSerwisowe = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel17 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox16 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel18 = new System.Windows.Forms.ToolStripLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDzialaniaSerwisowe)).BeginInit();
            this.toolStrip14.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(20, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1329, 700);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewDzialaniaSerwisowe);
            this.tabPage1.Controls.Add(this.toolStrip14);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1321, 657);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista działań serwisowych";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDzialaniaSerwisowe
            // 
            this.dataGridViewDzialaniaSerwisowe.AllowUserToAddRows = false;
            this.dataGridViewDzialaniaSerwisowe.AllowUserToDeleteRows = false;
            this.dataGridViewDzialaniaSerwisowe.AllowUserToResizeColumns = false;
            this.dataGridViewDzialaniaSerwisowe.AllowUserToResizeRows = false;
            this.dataGridViewDzialaniaSerwisowe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDzialaniaSerwisowe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column2,
            this.Column5,
            this.Column6});
            this.dataGridViewDzialaniaSerwisowe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDzialaniaSerwisowe.Location = new System.Drawing.Point(3, 55);
            this.dataGridViewDzialaniaSerwisowe.Name = "dataGridViewDzialaniaSerwisowe";
            this.dataGridViewDzialaniaSerwisowe.RowHeadersWidth = 72;
            this.dataGridViewDzialaniaSerwisowe.RowTemplate.Height = 37;
            this.dataGridViewDzialaniaSerwisowe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDzialaniaSerwisowe.Size = new System.Drawing.Size(1315, 599);
            this.dataGridViewDzialaniaSerwisowe.TabIndex = 18;
            this.dataGridViewDzialaniaSerwisowe.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewDzialaniaSerwisowe_CellMouseClick);
            this.dataGridViewDzialaniaSerwisowe.SelectionChanged += new System.EventHandler(this.dataGridViewDzialaniaSerwisowe_SelectionChanged);
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "SerwisId";
            this.Column7.HeaderText = "SerwisId";
            this.Column7.MinimumWidth = 9;
            this.Column7.Name = "Column7";
            this.Column7.Visible = false;
            this.Column7.Width = 175;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column8.DataPropertyName = "Lp";
            this.Column8.HeaderText = "Lp";
            this.Column8.MinimumWidth = 9;
            this.Column8.Name = "Column8";
            this.Column8.Width = 76;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Data";
            this.Column1.HeaderText = "Data";
            this.Column1.MinimumWidth = 9;
            this.Column1.Name = "Column1";
            this.Column1.Width = 175;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GodzinaRozpoczecia";
            this.Column3.HeaderText = "Godzina rozpoczęcia";
            this.Column3.MinimumWidth = 9;
            this.Column3.Name = "Column3";
            this.Column3.Width = 175;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GodzinaZakonczenia";
            this.Column4.HeaderText = "Godzina zakończenia";
            this.Column4.MinimumWidth = 9;
            this.Column4.Name = "Column4";
            this.Column4.Width = 175;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CzasTrwaniaSerwisu";
            this.Column2.HeaderText = "Czas trwania";
            this.Column2.MinimumWidth = 9;
            this.Column2.Name = "Column2";
            this.Column2.Width = 175;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SprawaZakonczona";
            this.Column5.HeaderText = "Sprawa zakończona";
            this.Column5.MinimumWidth = 9;
            this.Column5.Name = "Column5";
            this.Column5.Width = 175;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Sprzet";
            this.Column6.HeaderText = "Sprzęt";
            this.Column6.MinimumWidth = 9;
            this.Column6.Name = "Column6";
            this.Column6.Width = 175;
            // 
            // toolStrip14
            // 
            this.toolStrip14.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip14.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip14.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDodajDzialanieSerwisowe,
            this.toolStripButtonUsunDzialanieSerwisowe,
            this.toolStripButtonModyfikujDzialanieSerwisowe,
            this.toolStripComboBoxFirmyDzialaniaSerwisowe,
            this.toolStripLabel17,
            this.toolStripComboBox16,
            this.toolStripLabel18});
            this.toolStrip14.Location = new System.Drawing.Point(3, 3);
            this.toolStrip14.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStrip14.Name = "toolStrip14";
            this.toolStrip14.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip14.Size = new System.Drawing.Size(1315, 52);
            this.toolStrip14.TabIndex = 19;
            this.toolStrip14.Text = "toolStrip14";
            // 
            // toolStripButtonDodajDzialanieSerwisowe
            // 
            this.toolStripButtonDodajDzialanieSerwisowe.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDodajDzialanieSerwisowe.Image")));
            this.toolStripButtonDodajDzialanieSerwisowe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDodajDzialanieSerwisowe.Name = "toolStripButtonDodajDzialanieSerwisowe";
            this.toolStripButtonDodajDzialanieSerwisowe.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.toolStripButtonDodajDzialanieSerwisowe.Size = new System.Drawing.Size(100, 46);
            this.toolStripButtonDodajDzialanieSerwisowe.Text = "Dodaj";
            this.toolStripButtonDodajDzialanieSerwisowe.Click += new System.EventHandler(this.toolStripButtonDodajDzialanieSerwisowe_Click);
            // 
            // toolStripButtonUsunDzialanieSerwisowe
            // 
            this.toolStripButtonUsunDzialanieSerwisowe.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUsunDzialanieSerwisowe.Image")));
            this.toolStripButtonUsunDzialanieSerwisowe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUsunDzialanieSerwisowe.Name = "toolStripButtonUsunDzialanieSerwisowe";
            this.toolStripButtonUsunDzialanieSerwisowe.Size = new System.Drawing.Size(92, 46);
            this.toolStripButtonUsunDzialanieSerwisowe.Text = "Usuń";
            this.toolStripButtonUsunDzialanieSerwisowe.Click += new System.EventHandler(this.toolStripButtonUsunDzialanieSerwisowe_Click);
            // 
            // toolStripButtonModyfikujDzialanieSerwisowe
            // 
            this.toolStripButtonModyfikujDzialanieSerwisowe.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonModyfikujDzialanieSerwisowe.Image")));
            this.toolStripButtonModyfikujDzialanieSerwisowe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonModyfikujDzialanieSerwisowe.Name = "toolStripButtonModyfikujDzialanieSerwisowe";
            this.toolStripButtonModyfikujDzialanieSerwisowe.Size = new System.Drawing.Size(137, 46);
            this.toolStripButtonModyfikujDzialanieSerwisowe.Text = "Modyfikuj";
            this.toolStripButtonModyfikujDzialanieSerwisowe.Click += new System.EventHandler(this.toolStripButtonModyfikujDzialanieSerwisowe_Click);
            // 
            // toolStripComboBoxFirmyDzialaniaSerwisowe
            // 
            this.toolStripComboBoxFirmyDzialaniaSerwisowe.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBoxFirmyDzialaniaSerwisowe.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBoxFirmyDzialaniaSerwisowe.Name = "toolStripComboBoxFirmyDzialaniaSerwisowe";
            this.toolStripComboBoxFirmyDzialaniaSerwisowe.Size = new System.Drawing.Size(300, 52);
            this.toolStripComboBoxFirmyDzialaniaSerwisowe.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxFirmyDzialaniaSerwisowe_SelectedIndexChanged);
            // 
            // toolStripLabel17
            // 
            this.toolStripLabel17.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel17.Name = "toolStripLabel17";
            this.toolStripLabel17.Size = new System.Drawing.Size(64, 46);
            this.toolStripLabel17.Text = "Firma";
            // 
            // toolStripComboBox16
            // 
            this.toolStripComboBox16.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBox16.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBox16.Name = "toolStripComboBox16";
            this.toolStripComboBox16.Size = new System.Drawing.Size(300, 52);
            // 
            // toolStripLabel18
            // 
            this.toolStripLabel18.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel18.Name = "toolStripLabel18";
            this.toolStripLabel18.Size = new System.Drawing.Size(67, 46);
            this.toolStripLabel18.Text = "Pokaż";
            // 
            // DzialaniaSerwisoweUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "DzialaniaSerwisoweUserControl";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1369, 740);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDzialaniaSerwisowe)).EndInit();
            this.toolStrip14.ResumeLayout(false);
            this.toolStrip14.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewDzialaniaSerwisowe;
        private System.Windows.Forms.ToolStrip toolStrip14;
        private System.Windows.Forms.ToolStripButton toolStripButtonDodajDzialanieSerwisowe;
        private System.Windows.Forms.ToolStripButton toolStripButtonUsunDzialanieSerwisowe;
        private System.Windows.Forms.ToolStripButton toolStripButtonModyfikujDzialanieSerwisowe;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxFirmyDzialaniaSerwisowe;
        private System.Windows.Forms.ToolStripLabel toolStripLabel17;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox16;
        private System.Windows.Forms.ToolStripLabel toolStripLabel18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}


namespace WinFormsApp90.Forms.Umowy
{
    partial class UmowyUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UmowyUserControl));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewUmowy = new System.Windows.Forms.DataGridView();
            this.Column29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonUmowyDodaj = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUmowyUsun = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUmowyModyfikuj = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBoxFirmyUmowy = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel27 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox5 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel28 = new System.Windows.Forms.ToolStripLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUmowy)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(20, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(968, 567);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewUmowy);
            this.tabPage1.Controls.Add(this.toolStrip3);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(960, 524);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista umów";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUmowy
            // 
            this.dataGridViewUmowy.AllowUserToAddRows = false;
            this.dataGridViewUmowy.AllowUserToDeleteRows = false;
            this.dataGridViewUmowy.AllowUserToResizeColumns = false;
            this.dataGridViewUmowy.AllowUserToResizeRows = false;
            this.dataGridViewUmowy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUmowy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column29,
            this.Column30,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewUmowy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUmowy.Location = new System.Drawing.Point(3, 55);
            this.dataGridViewUmowy.Name = "dataGridViewUmowy";
            this.dataGridViewUmowy.RowHeadersWidth = 72;
            this.dataGridViewUmowy.RowTemplate.Height = 37;
            this.dataGridViewUmowy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUmowy.Size = new System.Drawing.Size(954, 466);
            this.dataGridViewUmowy.TabIndex = 17;
            this.dataGridViewUmowy.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewUmowy_CellMouseClick);
            this.dataGridViewUmowy.SelectionChanged += new System.EventHandler(this.dataGridViewUmowy_SelectionChanged);
            // 
            // Column29
            // 
            this.Column29.DataPropertyName = "UmowaId";
            this.Column29.HeaderText = "UmowaId";
            this.Column29.MinimumWidth = 9;
            this.Column29.Name = "Column29";
            this.Column29.Visible = false;
            this.Column29.Width = 175;
            // 
            // Column30
            // 
            this.Column30.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column30.DataPropertyName = "Lp";
            this.Column30.HeaderText = "Lp";
            this.Column30.MinimumWidth = 9;
            this.Column30.Name = "Column30";
            this.Column30.Width = 76;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "NumerUmowy";
            this.Column1.HeaderText = "Numer umowy";
            this.Column1.MinimumWidth = 9;
            this.Column1.Name = "Column1";
            this.Column1.Width = 175;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DataRozpoczecia";
            this.Column2.HeaderText = "Data rozpoczęcia";
            this.Column2.MinimumWidth = 9;
            this.Column2.Name = "Column2";
            this.Column2.Width = 175;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DataZakonczenia";
            this.Column3.HeaderText = "Data zakończenia";
            this.Column3.MinimumWidth = 9;
            this.Column3.Name = "Column3";
            this.Column3.Width = 175;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CzasNieokreslony";
            this.Column4.HeaderText = "Czas nieokreślony";
            this.Column4.MinimumWidth = 9;
            this.Column4.Name = "Column4";
            this.Column4.Width = 175;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "OkresWypowiedzenia";
            this.Column5.HeaderText = "Okres wypowiedzenia";
            this.Column5.MinimumWidth = 9;
            this.Column5.Name = "Column5";
            this.Column5.Width = 175;
            // 
            // toolStrip3
            // 
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonUmowyDodaj,
            this.toolStripButtonUmowyUsun,
            this.toolStripButtonUmowyModyfikuj,
            this.toolStripComboBoxFirmyUmowy,
            this.toolStripLabel27,
            this.toolStripComboBox5,
            this.toolStripLabel28});
            this.toolStrip3.Location = new System.Drawing.Point(3, 3);
            this.toolStrip3.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip3.Size = new System.Drawing.Size(954, 52);
            this.toolStrip3.TabIndex = 18;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripButtonUmowyDodaj
            // 
            this.toolStripButtonUmowyDodaj.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUmowyDodaj.Image")));
            this.toolStripButtonUmowyDodaj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUmowyDodaj.Name = "toolStripButtonUmowyDodaj";
            this.toolStripButtonUmowyDodaj.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.toolStripButtonUmowyDodaj.Size = new System.Drawing.Size(100, 46);
            this.toolStripButtonUmowyDodaj.Text = "Dodaj";
            this.toolStripButtonUmowyDodaj.Click += new System.EventHandler(this.toolStripButtonUmowyDodaj_Click);
            // 
            // toolStripButtonUmowyUsun
            // 
            this.toolStripButtonUmowyUsun.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUmowyUsun.Image")));
            this.toolStripButtonUmowyUsun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUmowyUsun.Name = "toolStripButtonUmowyUsun";
            this.toolStripButtonUmowyUsun.Size = new System.Drawing.Size(92, 46);
            this.toolStripButtonUmowyUsun.Text = "Usuń";
            this.toolStripButtonUmowyUsun.Click += new System.EventHandler(this.toolStripButtonUmowyUsun_Click);
            // 
            // toolStripButtonUmowyModyfikuj
            // 
            this.toolStripButtonUmowyModyfikuj.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUmowyModyfikuj.Image")));
            this.toolStripButtonUmowyModyfikuj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUmowyModyfikuj.Name = "toolStripButtonUmowyModyfikuj";
            this.toolStripButtonUmowyModyfikuj.Size = new System.Drawing.Size(137, 46);
            this.toolStripButtonUmowyModyfikuj.Text = "Modyfikuj";
            this.toolStripButtonUmowyModyfikuj.Click += new System.EventHandler(this.toolStripButtonUmowyModyfikuj_Click);
            // 
            // toolStripComboBoxFirmyUmowy
            // 
            this.toolStripComboBoxFirmyUmowy.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBoxFirmyUmowy.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBoxFirmyUmowy.Name = "toolStripComboBoxFirmyUmowy";
            this.toolStripComboBoxFirmyUmowy.Size = new System.Drawing.Size(300, 52);
            this.toolStripComboBoxFirmyUmowy.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxFirmyUmowy_SelectedIndexChanged);
            // 
            // toolStripLabel27
            // 
            this.toolStripLabel27.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel27.Name = "toolStripLabel27";
            this.toolStripLabel27.Size = new System.Drawing.Size(64, 46);
            this.toolStripLabel27.Text = "Firma";
            // 
            // toolStripComboBox5
            // 
            this.toolStripComboBox5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBox5.Name = "toolStripComboBox5";
            this.toolStripComboBox5.Size = new System.Drawing.Size(300, 38);
            // 
            // toolStripLabel28
            // 
            this.toolStripLabel28.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel28.Name = "toolStripLabel28";
            this.toolStripLabel28.Size = new System.Drawing.Size(67, 30);
            this.toolStripLabel28.Text = "Pokaż";
            // 
            // UmowyUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "UmowyUserControl";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1008, 607);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUmowy)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewUmowy;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton toolStripButtonUmowyDodaj;
        private System.Windows.Forms.ToolStripButton toolStripButtonUmowyUsun;
        private System.Windows.Forms.ToolStripButton toolStripButtonUmowyModyfikuj;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxFirmyUmowy;
        private System.Windows.Forms.ToolStripLabel toolStripLabel27;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel28;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column29;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column30;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

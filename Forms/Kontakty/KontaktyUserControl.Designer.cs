
namespace WinFormsApp90.Forms.Kontakty
{
    partial class KontaktyUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KontaktyUserControl));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewKontakty = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBoxFirmyKontakty = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel23 = new System.Windows.Forms.ToolStripLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKontakty)).BeginInit();
            this.toolStrip4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(20, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1299, 670);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewKontakty);
            this.tabPage1.Controls.Add(this.toolStrip4);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1291, 627);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista kontaktów";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewKontakty
            // 
            this.dataGridViewKontakty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKontakty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewKontakty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewKontakty.Location = new System.Drawing.Point(3, 55);
            this.dataGridViewKontakty.Name = "dataGridViewKontakty";
            this.dataGridViewKontakty.RowHeadersWidth = 72;
            this.dataGridViewKontakty.RowTemplate.Height = 37;
            this.dataGridViewKontakty.Size = new System.Drawing.Size(1285, 569);
            this.dataGridViewKontakty.TabIndex = 21;
            this.dataGridViewKontakty.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewKontakty_CellMouseClick);
            this.dataGridViewKontakty.SelectionChanged += new System.EventHandler(this.dataGridViewKontakty_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "KontaktId";
            this.Column1.HeaderText = "KontaktId";
            this.Column1.MinimumWidth = 9;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 175;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column2.DataPropertyName = "Lp";
            this.Column2.HeaderText = "Lp";
            this.Column2.MinimumWidth = 9;
            this.Column2.Name = "Column2";
            this.Column2.Width = 76;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Adres";
            this.Column3.HeaderText = "Adres";
            this.Column3.MinimumWidth = 9;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "AdresEmail";
            this.Column4.HeaderText = "Adres email";
            this.Column4.MinimumWidth = 9;
            this.Column4.Name = "Column4";
            this.Column4.Width = 175;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "OsobaKontaktowa";
            this.Column5.HeaderText = "Osoba kontaktowa";
            this.Column5.MinimumWidth = 9;
            this.Column5.Name = "Column5";
            this.Column5.Width = 175;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "NumerTelefonu";
            this.Column6.HeaderText = "Numer telefonu";
            this.Column6.MinimumWidth = 9;
            this.Column6.Name = "Column6";
            this.Column6.Width = 175;
            // 
            // toolStrip4
            // 
            this.toolStrip4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip4.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripComboBoxFirmyKontakty,
            this.toolStripLabel23});
            this.toolStrip4.Location = new System.Drawing.Point(3, 3);
            this.toolStrip4.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip4.Size = new System.Drawing.Size(1285, 52);
            this.toolStrip4.TabIndex = 20;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.toolStripButton1.Size = new System.Drawing.Size(100, 46);
            this.toolStripButton1.Text = "Dodaj";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(92, 46);
            this.toolStripButton2.Text = "Usuń";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(137, 46);
            this.toolStripButton3.Text = "Modyfikuj";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripComboBoxFirmyKontakty
            // 
            this.toolStripComboBoxFirmyKontakty.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBoxFirmyKontakty.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBoxFirmyKontakty.Name = "toolStripComboBoxFirmyKontakty";
            this.toolStripComboBoxFirmyKontakty.Size = new System.Drawing.Size(300, 52);
            this.toolStripComboBoxFirmyKontakty.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxFirmyKontakty_SelectedIndexChanged);
            // 
            // toolStripLabel23
            // 
            this.toolStripLabel23.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel23.Name = "toolStripLabel23";
            this.toolStripLabel23.Size = new System.Drawing.Size(64, 46);
            this.toolStripLabel23.Text = "Firma";
            // 
            // KontaktyUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "KontaktyUserControl";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1339, 710);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKontakty)).EndInit();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxFirmyKontakty;
        private System.Windows.Forms.ToolStripLabel toolStripLabel23;
        private System.Windows.Forms.DataGridView dataGridViewKontakty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}

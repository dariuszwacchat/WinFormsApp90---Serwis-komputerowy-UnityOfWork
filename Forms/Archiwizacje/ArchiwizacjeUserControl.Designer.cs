
namespace WinFormsApp90.Forms.Archiwizacje
{
    partial class ArchiwizacjeUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArchiwizacjeUserControl));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewArchiwizacje = new System.Windows.Forms.DataGridView();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip11 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDodajArchiwizacja = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUsunArchiwizacja = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonModyfikujArchiwizacja = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBoxFirmyArchiwizacja = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel11 = new System.Windows.Forms.ToolStripLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArchiwizacje)).BeginInit();
            this.toolStrip11.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(20, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1270, 664);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewArchiwizacje);
            this.tabPage1.Controls.Add(this.toolStrip11);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1262, 621);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista archiwizacji";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewArchiwizacje
            // 
            this.dataGridViewArchiwizacje.AllowUserToAddRows = false;
            this.dataGridViewArchiwizacje.AllowUserToDeleteRows = false;
            this.dataGridViewArchiwizacje.AllowUserToResizeColumns = false;
            this.dataGridViewArchiwizacje.AllowUserToResizeRows = false;
            this.dataGridViewArchiwizacje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArchiwizacje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column15,
            this.Column16,
            this.Column5,
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewArchiwizacje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewArchiwizacje.Location = new System.Drawing.Point(3, 55);
            this.dataGridViewArchiwizacje.Name = "dataGridViewArchiwizacje";
            this.dataGridViewArchiwizacje.RowHeadersWidth = 72;
            this.dataGridViewArchiwizacje.RowTemplate.Height = 37;
            this.dataGridViewArchiwizacje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewArchiwizacje.Size = new System.Drawing.Size(1256, 563);
            this.dataGridViewArchiwizacje.TabIndex = 16;
            this.dataGridViewArchiwizacje.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewArchiwizacje_CellContentClick);
            this.dataGridViewArchiwizacje.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewArchiwizacje_CellMouseClick);
            this.dataGridViewArchiwizacje.SelectionChanged += new System.EventHandler(this.dataGridViewArchiwizacje_SelectionChanged);
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "ArchiwizacjaId";
            this.Column15.HeaderText = "ArchiwizacjaId";
            this.Column15.MinimumWidth = 9;
            this.Column15.Name = "Column15";
            this.Column15.Visible = false;
            this.Column15.Width = 175;
            // 
            // Column16
            // 
            this.Column16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column16.DataPropertyName = "Lp";
            this.Column16.HeaderText = "Lp";
            this.Column16.MinimumWidth = 9;
            this.Column16.Name = "Column16";
            this.Column16.Width = 76;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DataArchiwizacji";
            this.Column5.HeaderText = "Data archiwizacji";
            this.Column5.MinimumWidth = 9;
            this.Column5.Name = "Column5";
            this.Column5.Width = 175;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "DaneDoArchiwizacji";
            this.Column6.HeaderText = "Dane do archiwizacji";
            this.Column6.MinimumWidth = 9;
            this.Column6.Name = "Column6";
            this.Column6.Width = 175;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "KopiaPrzekazana";
            this.Column1.HeaderText = "Kopia przekazana";
            this.Column1.MinimumWidth = 9;
            this.Column1.Name = "Column1";
            this.Column1.Width = 175;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NosnikArchiwizacji";
            this.Column2.HeaderText = "Nośnik archiwizacji";
            this.Column2.MinimumWidth = 9;
            this.Column2.Name = "Column2";
            this.Column2.Width = 175;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CzestotliwoscArchiwizacji";
            this.Column3.HeaderText = "Częstotliwość archiwizacji";
            this.Column3.MinimumWidth = 9;
            this.Column3.Name = "Column3";
            this.Column3.Width = 175;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Sprzet";
            this.Column4.HeaderText = "Sprzęt";
            this.Column4.MinimumWidth = 9;
            this.Column4.Name = "Column4";
            this.Column4.Width = 175;
            // 
            // toolStrip11
            // 
            this.toolStrip11.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip11.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip11.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDodajArchiwizacja,
            this.toolStripButtonUsunArchiwizacja,
            this.toolStripButtonModyfikujArchiwizacja,
            this.toolStripComboBoxFirmyArchiwizacja,
            this.toolStripLabel11});
            this.toolStrip11.Location = new System.Drawing.Point(3, 3);
            this.toolStrip11.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStrip11.Name = "toolStrip11";
            this.toolStrip11.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip11.Size = new System.Drawing.Size(1256, 52);
            this.toolStrip11.TabIndex = 17;
            this.toolStrip11.Text = "toolStrip11";
            // 
            // toolStripButtonDodajArchiwizacja
            // 
            this.toolStripButtonDodajArchiwizacja.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDodajArchiwizacja.Image")));
            this.toolStripButtonDodajArchiwizacja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDodajArchiwizacja.Name = "toolStripButtonDodajArchiwizacja";
            this.toolStripButtonDodajArchiwizacja.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.toolStripButtonDodajArchiwizacja.Size = new System.Drawing.Size(100, 46);
            this.toolStripButtonDodajArchiwizacja.Text = "Dodaj";
            this.toolStripButtonDodajArchiwizacja.Click += new System.EventHandler(this.toolStripButtonDodajArchiwizacja_Click);
            // 
            // toolStripButtonUsunArchiwizacja
            // 
            this.toolStripButtonUsunArchiwizacja.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUsunArchiwizacja.Image")));
            this.toolStripButtonUsunArchiwizacja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUsunArchiwizacja.Name = "toolStripButtonUsunArchiwizacja";
            this.toolStripButtonUsunArchiwizacja.Size = new System.Drawing.Size(92, 46);
            this.toolStripButtonUsunArchiwizacja.Text = "Usuń";
            this.toolStripButtonUsunArchiwizacja.Click += new System.EventHandler(this.toolStripButtonUsunArchiwizacja_Click);
            // 
            // toolStripButtonModyfikujArchiwizacja
            // 
            this.toolStripButtonModyfikujArchiwizacja.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonModyfikujArchiwizacja.Image")));
            this.toolStripButtonModyfikujArchiwizacja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonModyfikujArchiwizacja.Name = "toolStripButtonModyfikujArchiwizacja";
            this.toolStripButtonModyfikujArchiwizacja.Size = new System.Drawing.Size(137, 46);
            this.toolStripButtonModyfikujArchiwizacja.Text = "Modyfikuj";
            this.toolStripButtonModyfikujArchiwizacja.Click += new System.EventHandler(this.toolStripButtonModyfikujArchiwizacja_Click);
            // 
            // toolStripComboBoxFirmyArchiwizacja
            // 
            this.toolStripComboBoxFirmyArchiwizacja.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBoxFirmyArchiwizacja.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBoxFirmyArchiwizacja.Name = "toolStripComboBoxFirmyArchiwizacja";
            this.toolStripComboBoxFirmyArchiwizacja.Size = new System.Drawing.Size(300, 52);
            this.toolStripComboBoxFirmyArchiwizacja.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxFirmyArchiwizacja_SelectedIndexChanged);
            // 
            // toolStripLabel11
            // 
            this.toolStripLabel11.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel11.Name = "toolStripLabel11";
            this.toolStripLabel11.Size = new System.Drawing.Size(64, 46);
            this.toolStripLabel11.Text = "Firma";
            // 
            // ArchiwizacjeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "ArchiwizacjeUserControl";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1310, 704);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArchiwizacje)).EndInit();
            this.toolStrip11.ResumeLayout(false);
            this.toolStrip11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewArchiwizacje;
        private System.Windows.Forms.ToolStrip toolStrip11;
        private System.Windows.Forms.ToolStripButton toolStripButtonDodajArchiwizacja;
        private System.Windows.Forms.ToolStripButton toolStripButtonUsunArchiwizacja;
        private System.Windows.Forms.ToolStripButton toolStripButtonModyfikujArchiwizacja;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxFirmyArchiwizacja;
        private System.Windows.Forms.ToolStripLabel toolStripLabel11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

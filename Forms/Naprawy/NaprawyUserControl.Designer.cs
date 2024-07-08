
namespace WinFormsApp90.Forms.Naprawy
{
    partial class NaprawyUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NaprawyUserControl));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewNaprawy = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripFirmyNaprawy = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDodajNaprawy = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUsunNaprawy = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonModyfikujNaprawy = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBoxFirmyNaprawy = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel15 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox14 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel16 = new System.Windows.Forms.ToolStripLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNaprawy)).BeginInit();
            this.toolStripFirmyNaprawy.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(20, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1277, 653);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewNaprawy);
            this.tabPage1.Controls.Add(this.toolStripFirmyNaprawy);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1269, 610);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista napraw";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewNaprawy
            // 
            this.dataGridViewNaprawy.AllowUserToAddRows = false;
            this.dataGridViewNaprawy.AllowUserToDeleteRows = false;
            this.dataGridViewNaprawy.AllowUserToResizeColumns = false;
            this.dataGridViewNaprawy.AllowUserToResizeRows = false;
            this.dataGridViewNaprawy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNaprawy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column10,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewNaprawy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNaprawy.Location = new System.Drawing.Point(3, 55);
            this.dataGridViewNaprawy.Name = "dataGridViewNaprawy";
            this.dataGridViewNaprawy.RowHeadersWidth = 72;
            this.dataGridViewNaprawy.RowTemplate.Height = 37;
            this.dataGridViewNaprawy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNaprawy.Size = new System.Drawing.Size(1263, 552);
            this.dataGridViewNaprawy.TabIndex = 16;
            this.dataGridViewNaprawy.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewNaprawy_CellMouseClick);
            this.dataGridViewNaprawy.SelectionChanged += new System.EventHandler(this.dataGridViewNaprawy_SelectionChanged);
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "NaprawaId";
            this.Column9.HeaderText = "NaprawaId";
            this.Column9.MinimumWidth = 9;
            this.Column9.Name = "Column9";
            this.Column9.Visible = false;
            this.Column9.Width = 175;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column10.DataPropertyName = "Lp";
            this.Column10.HeaderText = "Lp";
            this.Column10.MinimumWidth = 9;
            this.Column10.Name = "Column10";
            this.Column10.Width = 76;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "DataNaprawy";
            this.Column1.HeaderText = "Data naprawy";
            this.Column1.MinimumWidth = 9;
            this.Column1.Name = "Column1";
            this.Column1.Width = 175;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CzasUdzielonejGwarancji";
            this.Column2.HeaderText = "Czas udzielonej gwarancji";
            this.Column2.MinimumWidth = 9;
            this.Column2.Name = "Column2";
            this.Column2.Width = 175;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DataZakonczeniaGwarancji";
            this.Column3.HeaderText = "Data zakończenia gwarancji";
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
            // Column5
            // 
            this.Column5.DataPropertyName = "Uwagi";
            this.Column5.HeaderText = "Uwagi";
            this.Column5.MinimumWidth = 9;
            this.Column5.Name = "Column5";
            this.Column5.Width = 175;
            // 
            // toolStripFirmyNaprawy
            // 
            this.toolStripFirmyNaprawy.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripFirmyNaprawy.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStripFirmyNaprawy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDodajNaprawy,
            this.toolStripButtonUsunNaprawy,
            this.toolStripButtonModyfikujNaprawy,
            this.toolStripComboBoxFirmyNaprawy,
            this.toolStripLabel15,
            this.toolStripComboBox14,
            this.toolStripLabel16});
            this.toolStripFirmyNaprawy.Location = new System.Drawing.Point(3, 3);
            this.toolStripFirmyNaprawy.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStripFirmyNaprawy.Name = "toolStripFirmyNaprawy";
            this.toolStripFirmyNaprawy.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripFirmyNaprawy.Size = new System.Drawing.Size(1263, 52);
            this.toolStripFirmyNaprawy.TabIndex = 17;
            this.toolStripFirmyNaprawy.Text = "toolStrip13";
            // 
            // toolStripButtonDodajNaprawy
            // 
            this.toolStripButtonDodajNaprawy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDodajNaprawy.Image")));
            this.toolStripButtonDodajNaprawy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDodajNaprawy.Name = "toolStripButtonDodajNaprawy";
            this.toolStripButtonDodajNaprawy.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.toolStripButtonDodajNaprawy.Size = new System.Drawing.Size(100, 46);
            this.toolStripButtonDodajNaprawy.Text = "Dodaj";
            this.toolStripButtonDodajNaprawy.Click += new System.EventHandler(this.toolStripButtonDodajNaprawy_Click);
            // 
            // toolStripButtonUsunNaprawy
            // 
            this.toolStripButtonUsunNaprawy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUsunNaprawy.Image")));
            this.toolStripButtonUsunNaprawy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUsunNaprawy.Name = "toolStripButtonUsunNaprawy";
            this.toolStripButtonUsunNaprawy.Size = new System.Drawing.Size(92, 46);
            this.toolStripButtonUsunNaprawy.Text = "Usuń";
            this.toolStripButtonUsunNaprawy.Click += new System.EventHandler(this.toolStripButtonUsunNaprawy_Click);
            // 
            // toolStripButtonModyfikujNaprawy
            // 
            this.toolStripButtonModyfikujNaprawy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonModyfikujNaprawy.Image")));
            this.toolStripButtonModyfikujNaprawy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonModyfikujNaprawy.Name = "toolStripButtonModyfikujNaprawy";
            this.toolStripButtonModyfikujNaprawy.Size = new System.Drawing.Size(137, 46);
            this.toolStripButtonModyfikujNaprawy.Text = "Modyfikuj";
            this.toolStripButtonModyfikujNaprawy.Click += new System.EventHandler(this.toolStripButtonModyfikujNaprawy_Click);
            // 
            // toolStripComboBoxFirmyNaprawy
            // 
            this.toolStripComboBoxFirmyNaprawy.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBoxFirmyNaprawy.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBoxFirmyNaprawy.Name = "toolStripComboBoxFirmyNaprawy";
            this.toolStripComboBoxFirmyNaprawy.Size = new System.Drawing.Size(300, 52);
            this.toolStripComboBoxFirmyNaprawy.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxFirmyNaprawy_SelectedIndexChanged);
            // 
            // toolStripLabel15
            // 
            this.toolStripLabel15.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel15.Name = "toolStripLabel15";
            this.toolStripLabel15.Size = new System.Drawing.Size(64, 46);
            this.toolStripLabel15.Text = "Firma";
            // 
            // toolStripComboBox14
            // 
            this.toolStripComboBox14.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBox14.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBox14.Name = "toolStripComboBox14";
            this.toolStripComboBox14.Size = new System.Drawing.Size(300, 52);
            // 
            // toolStripLabel16
            // 
            this.toolStripLabel16.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel16.Name = "toolStripLabel16";
            this.toolStripLabel16.Size = new System.Drawing.Size(67, 46);
            this.toolStripLabel16.Text = "Pokaż";
            // 
            // NaprawyUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "NaprawyUserControl";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1317, 693);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNaprawy)).EndInit();
            this.toolStripFirmyNaprawy.ResumeLayout(false);
            this.toolStripFirmyNaprawy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewNaprawy;
        private System.Windows.Forms.ToolStrip toolStripFirmyNaprawy;
        private System.Windows.Forms.ToolStripButton toolStripButtonDodajNaprawy;
        private System.Windows.Forms.ToolStripButton toolStripButtonUsunNaprawy;
        private System.Windows.Forms.ToolStripButton toolStripButtonModyfikujNaprawy;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxFirmyNaprawy;
        private System.Windows.Forms.ToolStripLabel toolStripLabel15;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox14;
        private System.Windows.Forms.ToolStripLabel toolStripLabel16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

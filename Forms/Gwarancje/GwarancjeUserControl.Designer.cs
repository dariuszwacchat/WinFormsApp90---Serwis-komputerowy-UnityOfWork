
namespace WinFormsApp90.Forms.Gwarancje
{
    partial class GwarancjeUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GwarancjeUserControl));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewGwarancje = new System.Windows.Forms.DataGridView();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip10 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDodajGwarancje = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUsunGwarancje = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonModyfikujGwarancje = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBoxFirmyGwarancje = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel9 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox8 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel10 = new System.Windows.Forms.ToolStripLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGwarancje)).BeginInit();
            this.toolStrip10.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(20, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1252, 664);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewGwarancje);
            this.tabPage1.Controls.Add(this.toolStrip10);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1244, 621);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista gwarancji";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewGwarancje
            // 
            this.dataGridViewGwarancje.AllowUserToAddRows = false;
            this.dataGridViewGwarancje.AllowUserToDeleteRows = false;
            this.dataGridViewGwarancje.AllowUserToResizeColumns = false;
            this.dataGridViewGwarancje.AllowUserToResizeRows = false;
            this.dataGridViewGwarancje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGwarancje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column17,
            this.Column18,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewGwarancje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewGwarancje.Location = new System.Drawing.Point(3, 55);
            this.dataGridViewGwarancje.Name = "dataGridViewGwarancje";
            this.dataGridViewGwarancje.RowHeadersWidth = 72;
            this.dataGridViewGwarancje.RowTemplate.Height = 37;
            this.dataGridViewGwarancje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGwarancje.Size = new System.Drawing.Size(1238, 563);
            this.dataGridViewGwarancje.TabIndex = 16;
            this.dataGridViewGwarancje.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewGwarancje_CellMouseClick);
            this.dataGridViewGwarancje.SelectionChanged += new System.EventHandler(this.dataGridViewGwarancje_SelectionChanged);
            // 
            // Column17
            // 
            this.Column17.DataPropertyName = "GwarancjaId";
            this.Column17.HeaderText = "GwarancjaId";
            this.Column17.MinimumWidth = 9;
            this.Column17.Name = "Column17";
            this.Column17.Visible = false;
            this.Column17.Width = 175;
            // 
            // Column18
            // 
            this.Column18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column18.DataPropertyName = "Lp";
            this.Column18.HeaderText = "Lp";
            this.Column18.MinimumWidth = 9;
            this.Column18.Name = "Column18";
            this.Column18.Width = 76;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "DataRozpoczeciaGwarancji";
            this.Column1.HeaderText = "Data rozpoczęcia gwarancji";
            this.Column1.MinimumWidth = 9;
            this.Column1.Name = "Column1";
            this.Column1.Width = 175;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DataZakonczeniaGwarancji";
            this.Column2.HeaderText = "Data zakończenia gwarancji";
            this.Column2.MinimumWidth = 9;
            this.Column2.Name = "Column2";
            this.Column2.Width = 175;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CzasGwarancji";
            this.Column3.HeaderText = "Czas gwarancji";
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
            // toolStrip10
            // 
            this.toolStrip10.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip10.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip10.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDodajGwarancje,
            this.toolStripButtonUsunGwarancje,
            this.toolStripButtonModyfikujGwarancje,
            this.toolStripComboBoxFirmyGwarancje,
            this.toolStripLabel9,
            this.toolStripComboBox8,
            this.toolStripLabel10});
            this.toolStrip10.Location = new System.Drawing.Point(3, 3);
            this.toolStrip10.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStrip10.Name = "toolStrip10";
            this.toolStrip10.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip10.Size = new System.Drawing.Size(1238, 52);
            this.toolStrip10.TabIndex = 17;
            this.toolStrip10.Text = "toolStrip10";
            // 
            // toolStripButtonDodajGwarancje
            // 
            this.toolStripButtonDodajGwarancje.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDodajGwarancje.Image")));
            this.toolStripButtonDodajGwarancje.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDodajGwarancje.Name = "toolStripButtonDodajGwarancje";
            this.toolStripButtonDodajGwarancje.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.toolStripButtonDodajGwarancje.Size = new System.Drawing.Size(100, 46);
            this.toolStripButtonDodajGwarancje.Text = "Dodaj";
            this.toolStripButtonDodajGwarancje.Click += new System.EventHandler(this.toolStripButtonDodajGwarancje_Click);
            // 
            // toolStripButtonUsunGwarancje
            // 
            this.toolStripButtonUsunGwarancje.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUsunGwarancje.Image")));
            this.toolStripButtonUsunGwarancje.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUsunGwarancje.Name = "toolStripButtonUsunGwarancje";
            this.toolStripButtonUsunGwarancje.Size = new System.Drawing.Size(92, 46);
            this.toolStripButtonUsunGwarancje.Text = "Usuń";
            this.toolStripButtonUsunGwarancje.Click += new System.EventHandler(this.toolStripButtonUsunGwarancje_Click);
            // 
            // toolStripButtonModyfikujGwarancje
            // 
            this.toolStripButtonModyfikujGwarancje.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonModyfikujGwarancje.Image")));
            this.toolStripButtonModyfikujGwarancje.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonModyfikujGwarancje.Name = "toolStripButtonModyfikujGwarancje";
            this.toolStripButtonModyfikujGwarancje.Size = new System.Drawing.Size(137, 46);
            this.toolStripButtonModyfikujGwarancje.Text = "Modyfikuj";
            this.toolStripButtonModyfikujGwarancje.Click += new System.EventHandler(this.toolStripButtonModyfikujGwarancje_Click);
            // 
            // toolStripComboBoxFirmyGwarancje
            // 
            this.toolStripComboBoxFirmyGwarancje.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBoxFirmyGwarancje.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBoxFirmyGwarancje.Name = "toolStripComboBoxFirmyGwarancje";
            this.toolStripComboBoxFirmyGwarancje.Size = new System.Drawing.Size(300, 52);
            this.toolStripComboBoxFirmyGwarancje.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxFirmyGwarancje_SelectedIndexChanged);
            // 
            // toolStripLabel9
            // 
            this.toolStripLabel9.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel9.Name = "toolStripLabel9";
            this.toolStripLabel9.Size = new System.Drawing.Size(64, 46);
            this.toolStripLabel9.Text = "Firma";
            // 
            // toolStripComboBox8
            // 
            this.toolStripComboBox8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBox8.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBox8.Name = "toolStripComboBox8";
            this.toolStripComboBox8.Size = new System.Drawing.Size(300, 52);
            // 
            // toolStripLabel10
            // 
            this.toolStripLabel10.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel10.Name = "toolStripLabel10";
            this.toolStripLabel10.Size = new System.Drawing.Size(67, 46);
            this.toolStripLabel10.Text = "Pokaż";
            // 
            // GwarancjeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "GwarancjeUserControl";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1292, 704);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGwarancje)).EndInit();
            this.toolStrip10.ResumeLayout(false);
            this.toolStrip10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewGwarancje;
        private System.Windows.Forms.ToolStrip toolStrip10;
        private System.Windows.Forms.ToolStripButton toolStripButtonDodajGwarancje;
        private System.Windows.Forms.ToolStripButton toolStripButtonUsunGwarancje;
        private System.Windows.Forms.ToolStripButton toolStripButtonModyfikujGwarancje;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxFirmyGwarancje;
        private System.Windows.Forms.ToolStripLabel toolStripLabel9;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox8;
        private System.Windows.Forms.ToolStripLabel toolStripLabel10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

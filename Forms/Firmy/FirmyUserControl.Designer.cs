
namespace WinFormsApp90.Forms.Firmy
{
    partial class FirmyUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirmyUserControl));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewFirmy = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDodajFirma = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUsunFirma = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonModyfikujFirma = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFirmy)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(20, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1338, 684);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewFirmy);
            this.tabPage1.Controls.Add(this.toolStrip2);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1330, 641);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista firm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFirmy
            // 
            this.dataGridViewFirmy.AllowUserToAddRows = false;
            this.dataGridViewFirmy.AllowUserToDeleteRows = false;
            this.dataGridViewFirmy.AllowUserToResizeColumns = false;
            this.dataGridViewFirmy.AllowUserToResizeRows = false;
            this.dataGridViewFirmy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFirmy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column1,
            this.Column2});
            this.dataGridViewFirmy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFirmy.Location = new System.Drawing.Point(3, 55);
            this.dataGridViewFirmy.Name = "dataGridViewFirmy";
            this.dataGridViewFirmy.RowHeadersWidth = 72;
            this.dataGridViewFirmy.RowTemplate.Height = 37;
            this.dataGridViewFirmy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFirmy.Size = new System.Drawing.Size(1324, 583);
            this.dataGridViewFirmy.TabIndex = 14;
            this.dataGridViewFirmy.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewFirmy_CellMouseClick);
            this.dataGridViewFirmy.SelectionChanged += new System.EventHandler(this.dataGridViewFirmy_SelectionChanged);
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDodajFirma,
            this.toolStripButtonUsunFirma,
            this.toolStripButtonModyfikujFirma,
            this.toolStripTextBox1});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip2.Size = new System.Drawing.Size(1324, 52);
            this.toolStrip2.TabIndex = 15;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButtonDodajFirma
            // 
            this.toolStripButtonDodajFirma.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDodajFirma.Image")));
            this.toolStripButtonDodajFirma.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDodajFirma.Name = "toolStripButtonDodajFirma";
            this.toolStripButtonDodajFirma.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.toolStripButtonDodajFirma.Size = new System.Drawing.Size(100, 46);
            this.toolStripButtonDodajFirma.Text = "Dodaj";
            this.toolStripButtonDodajFirma.Click += new System.EventHandler(this.toolStripButtonDodajFirma_Click);
            // 
            // toolStripButtonUsunFirma
            // 
            this.toolStripButtonUsunFirma.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUsunFirma.Image")));
            this.toolStripButtonUsunFirma.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUsunFirma.Name = "toolStripButtonUsunFirma";
            this.toolStripButtonUsunFirma.Size = new System.Drawing.Size(92, 46);
            this.toolStripButtonUsunFirma.Text = "Usuń";
            this.toolStripButtonUsunFirma.Click += new System.EventHandler(this.toolStripButtonUsunFirma_Click);
            // 
            // toolStripButtonModyfikujFirma
            // 
            this.toolStripButtonModyfikujFirma.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonModyfikujFirma.Image")));
            this.toolStripButtonModyfikujFirma.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonModyfikujFirma.Name = "toolStripButtonModyfikujFirma";
            this.toolStripButtonModyfikujFirma.Size = new System.Drawing.Size(137, 46);
            this.toolStripButtonModyfikujFirma.Text = "Modyfikuj";
            this.toolStripButtonModyfikujFirma.Click += new System.EventHandler(this.toolStripButtonModyfikujFirma_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(300, 52);
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "FirmaId";
            this.Column3.HeaderText = "FirmaId";
            this.Column3.MinimumWidth = 9;
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            this.Column3.Width = 175;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column4.DataPropertyName = "Lp";
            this.Column4.HeaderText = "Lp";
            this.Column4.MinimumWidth = 9;
            this.Column4.Name = "Column4";
            this.Column4.Width = 76;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PelnaNazwa";
            this.Column1.HeaderText = "Pełna nazwa";
            this.Column1.MinimumWidth = 9;
            this.Column1.Name = "Column1";
            this.Column1.Width = 175;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "SkroconaNazwa";
            this.Column2.HeaderText = "Skrócona nazwa";
            this.Column2.MinimumWidth = 9;
            this.Column2.Name = "Column2";
            this.Column2.Width = 175;
            // 
            // FirmyUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "FirmyUserControl";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1378, 724);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFirmy)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewFirmy;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButtonDodajFirma;
        private System.Windows.Forms.ToolStripButton toolStripButtonUsunFirma;
        private System.Windows.Forms.ToolStripButton toolStripButtonModyfikujFirma;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

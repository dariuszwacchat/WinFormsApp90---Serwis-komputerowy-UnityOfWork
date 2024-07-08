
namespace WinFormsApp90.Forms.Sprzety
{
    partial class SprzetUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SprzetUserControl));
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridViewPola = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewSprzet = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDodaj = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUsun = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonModyfikuj = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBoxFirmySprzet = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tableLayoutPanel5.SuspendLayout();
            this.tabControl4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPola)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSprzet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.tabControl4, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1508, 629);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // tabControl4
            // 
            this.tabControl4.Controls.Add(this.tabPage5);
            this.tabControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl4.Location = new System.Drawing.Point(757, 3);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(748, 623);
            this.tabControl4.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridViewPola);
            this.tabPage5.Location = new System.Drawing.Point(4, 39);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(740, 580);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Podgląd właściwości";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPola
            // 
            this.dataGridViewPola.AllowUserToAddRows = false;
            this.dataGridViewPola.AllowUserToDeleteRows = false;
            this.dataGridViewPola.AllowUserToOrderColumns = true;
            this.dataGridViewPola.AllowUserToResizeColumns = false;
            this.dataGridViewPola.AllowUserToResizeRows = false;
            this.dataGridViewPola.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPola.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewPola.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPola.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewPola.MultiSelect = false;
            this.dataGridViewPola.Name = "dataGridViewPola";
            this.dataGridViewPola.RowHeadersVisible = false;
            this.dataGridViewPola.RowHeadersWidth = 72;
            this.dataGridViewPola.RowTemplate.Height = 37;
            this.dataGridViewPola.Size = new System.Drawing.Size(734, 574);
            this.dataGridViewPola.TabIndex = 119;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "Nazwa";
            this.Column1.MinimumWidth = 9;
            this.Column1.Name = "Column1";
            this.Column1.Width = 117;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Wartosc";
            this.Column2.HeaderText = "Opis";
            this.Column2.MinimumWidth = 9;
            this.Column2.Name = "Column2";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(748, 623);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewSprzet);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(740, 580);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista sprzętów";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSprzet
            // 
            this.dataGridViewSprzet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSprzet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewSprzet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSprzet.Location = new System.Drawing.Point(3, 55);
            this.dataGridViewSprzet.Name = "dataGridViewSprzet";
            this.dataGridViewSprzet.RowHeadersWidth = 72;
            this.dataGridViewSprzet.RowTemplate.Height = 37;
            this.dataGridViewSprzet.Size = new System.Drawing.Size(734, 522);
            this.dataGridViewSprzet.TabIndex = 14;
            this.dataGridViewSprzet.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSprzet_CellMouseClick);
            this.dataGridViewSprzet.SelectionChanged += new System.EventHandler(this.dataGridViewSprzet_SelectionChanged);
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SprzetId";
            this.Column3.HeaderText = "SprzetId";
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
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "Nazwa";
            this.Column5.HeaderText = "Nazwa";
            this.Column5.MinimumWidth = 9;
            this.Column5.Name = "Column5";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDodaj,
            this.toolStripButtonUsun,
            this.toolStripButtonModyfikuj,
            this.toolStripComboBoxFirmySprzet,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(734, 52);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonDodaj
            // 
            this.toolStripButtonDodaj.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDodaj.Image")));
            this.toolStripButtonDodaj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDodaj.Name = "toolStripButtonDodaj";
            this.toolStripButtonDodaj.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.toolStripButtonDodaj.Size = new System.Drawing.Size(100, 46);
            this.toolStripButtonDodaj.Text = "Dodaj";
            this.toolStripButtonDodaj.Click += new System.EventHandler(this.toolStripButtonDodaj_Click);
            // 
            // toolStripButtonUsun
            // 
            this.toolStripButtonUsun.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUsun.Image")));
            this.toolStripButtonUsun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUsun.Name = "toolStripButtonUsun";
            this.toolStripButtonUsun.Size = new System.Drawing.Size(92, 46);
            this.toolStripButtonUsun.Text = "Usuń";
            this.toolStripButtonUsun.Click += new System.EventHandler(this.toolStripButtonUsun_Click);
            // 
            // toolStripButtonModyfikuj
            // 
            this.toolStripButtonModyfikuj.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonModyfikuj.Image")));
            this.toolStripButtonModyfikuj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonModyfikuj.Name = "toolStripButtonModyfikuj";
            this.toolStripButtonModyfikuj.Size = new System.Drawing.Size(137, 46);
            this.toolStripButtonModyfikuj.Text = "Modyfikuj";
            this.toolStripButtonModyfikuj.Click += new System.EventHandler(this.toolStripButtonModyfikuj_Click);
            // 
            // toolStripComboBoxFirmySprzet
            // 
            this.toolStripComboBoxFirmySprzet.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBoxFirmySprzet.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBoxFirmySprzet.Name = "toolStripComboBoxFirmySprzet";
            this.toolStripComboBoxFirmySprzet.Size = new System.Drawing.Size(300, 52);
            this.toolStripComboBoxFirmySprzet.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxFirmySprzet_SelectedIndexChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(64, 46);
            this.toolStripLabel2.Text = "Firma";
            // 
            // SprzetUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel5);
            this.Name = "SprzetUserControl";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1548, 669);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tabControl4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPola)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSprzet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TabControl tabControl4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridViewPola;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewSprzet;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonDodaj;
        private System.Windows.Forms.ToolStripButton toolStripButtonUsun;
        private System.Windows.Forms.ToolStripButton toolStripButtonModyfikuj;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxFirmySprzet;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}


namespace WinFormsApp90.Forms.Pracownicy
{
    partial class PracownicyUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PracownicyUserControl));
            this.tabControl33 = new System.Windows.Forms.TabControl();
            this.tabPage68 = new System.Windows.Forms.TabPage();
            this.dataGridViewPracownicy = new System.Windows.Forms.DataGridView();
            this.toolStrip16 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDodajPracownika = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUsunPracownika = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonModyfikujPracownika = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBoxUprawnienia = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel22 = new System.Windows.Forms.ToolStripLabel();
            this.Column31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl33.SuspendLayout();
            this.tabPage68.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPracownicy)).BeginInit();
            this.toolStrip16.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl33
            // 
            this.tabControl33.Controls.Add(this.tabPage68);
            this.tabControl33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl33.Location = new System.Drawing.Point(20, 20);
            this.tabControl33.Name = "tabControl33";
            this.tabControl33.SelectedIndex = 0;
            this.tabControl33.Size = new System.Drawing.Size(1208, 643);
            this.tabControl33.TabIndex = 9;
            // 
            // tabPage68
            // 
            this.tabPage68.Controls.Add(this.dataGridViewPracownicy);
            this.tabPage68.Controls.Add(this.toolStrip16);
            this.tabPage68.Location = new System.Drawing.Point(4, 39);
            this.tabPage68.Name = "tabPage68";
            this.tabPage68.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage68.Size = new System.Drawing.Size(1200, 600);
            this.tabPage68.TabIndex = 0;
            this.tabPage68.Text = "Lista pracowników";
            this.tabPage68.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPracownicy
            // 
            this.dataGridViewPracownicy.AllowUserToAddRows = false;
            this.dataGridViewPracownicy.AllowUserToDeleteRows = false;
            this.dataGridViewPracownicy.AllowUserToResizeColumns = false;
            this.dataGridViewPracownicy.AllowUserToResizeRows = false;
            this.dataGridViewPracownicy.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPracownicy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPracownicy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPracownicy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column31,
            this.Column32,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPracownicy.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPracownicy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPracownicy.Location = new System.Drawing.Point(3, 55);
            this.dataGridViewPracownicy.Name = "dataGridViewPracownicy";
            this.dataGridViewPracownicy.RowHeadersWidth = 72;
            this.dataGridViewPracownicy.RowTemplate.Height = 37;
            this.dataGridViewPracownicy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPracownicy.Size = new System.Drawing.Size(1194, 542);
            this.dataGridViewPracownicy.TabIndex = 12;
            this.dataGridViewPracownicy.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewPracownicy_CellMouseClick);
            this.dataGridViewPracownicy.SelectionChanged += new System.EventHandler(this.dataGridViewPracownicy_SelectionChanged);
            // 
            // toolStrip16
            // 
            this.toolStrip16.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip16.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip16.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDodajPracownika,
            this.toolStripButtonUsunPracownika,
            this.toolStripButtonModyfikujPracownika,
            this.toolStripComboBoxUprawnienia,
            this.toolStripLabel22});
            this.toolStrip16.Location = new System.Drawing.Point(3, 3);
            this.toolStrip16.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStrip16.Name = "toolStrip16";
            this.toolStrip16.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip16.Size = new System.Drawing.Size(1194, 52);
            this.toolStrip16.TabIndex = 13;
            this.toolStrip16.Text = "toolStrip16";
            // 
            // toolStripButtonDodajPracownika
            // 
            this.toolStripButtonDodajPracownika.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDodajPracownika.Image")));
            this.toolStripButtonDodajPracownika.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDodajPracownika.Name = "toolStripButtonDodajPracownika";
            this.toolStripButtonDodajPracownika.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.toolStripButtonDodajPracownika.Size = new System.Drawing.Size(100, 46);
            this.toolStripButtonDodajPracownika.Text = "Dodaj";
            this.toolStripButtonDodajPracownika.Click += new System.EventHandler(this.toolStripButtonDodajPracownika_Click);
            // 
            // toolStripButtonUsunPracownika
            // 
            this.toolStripButtonUsunPracownika.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUsunPracownika.Image")));
            this.toolStripButtonUsunPracownika.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUsunPracownika.Name = "toolStripButtonUsunPracownika";
            this.toolStripButtonUsunPracownika.Size = new System.Drawing.Size(92, 46);
            this.toolStripButtonUsunPracownika.Text = "Usuń";
            this.toolStripButtonUsunPracownika.Click += new System.EventHandler(this.toolStripButtonUsunPracownika_Click);
            // 
            // toolStripButtonModyfikujPracownika
            // 
            this.toolStripButtonModyfikujPracownika.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonModyfikujPracownika.Image")));
            this.toolStripButtonModyfikujPracownika.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonModyfikujPracownika.Name = "toolStripButtonModyfikujPracownika";
            this.toolStripButtonModyfikujPracownika.Size = new System.Drawing.Size(137, 46);
            this.toolStripButtonModyfikujPracownika.Text = "Modyfikuj";
            this.toolStripButtonModyfikujPracownika.Click += new System.EventHandler(this.toolStripButtonModyfikujPracownika_Click);
            // 
            // toolStripComboBoxUprawnienia
            // 
            this.toolStripComboBoxUprawnienia.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBoxUprawnienia.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBoxUprawnienia.Name = "toolStripComboBoxUprawnienia";
            this.toolStripComboBoxUprawnienia.Size = new System.Drawing.Size(300, 52);
            // 
            // toolStripLabel22
            // 
            this.toolStripLabel22.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel22.Name = "toolStripLabel22";
            this.toolStripLabel22.Size = new System.Drawing.Size(128, 46);
            this.toolStripLabel22.Text = "Uprawnienie";
            // 
            // Column31
            // 
            this.Column31.DataPropertyName = "Id";
            this.Column31.HeaderText = "Id";
            this.Column31.MinimumWidth = 9;
            this.Column31.Name = "Column31";
            this.Column31.Visible = false;
            this.Column31.Width = 175;
            // 
            // Column32
            // 
            this.Column32.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column32.DataPropertyName = "Lp";
            this.Column32.HeaderText = "Lp";
            this.Column32.MinimumWidth = 9;
            this.Column32.Name = "Column32";
            this.Column32.Width = 76;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Imie";
            this.Column1.HeaderText = "Imię";
            this.Column1.MinimumWidth = 9;
            this.Column1.Name = "Column1";
            this.Column1.Width = 175;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Nazwisko";
            this.Column2.HeaderText = "Nazwisko";
            this.Column2.MinimumWidth = 9;
            this.Column2.Name = "Column2";
            this.Column2.Width = 175;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "AdresEmailSluzbowy";
            this.Column3.HeaderText = "Adres email służbowy";
            this.Column3.MinimumWidth = 9;
            this.Column3.Name = "Column3";
            this.Column3.Width = 175;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NumerGG";
            this.Column4.HeaderText = "Numer GG";
            this.Column4.MinimumWidth = 9;
            this.Column4.Name = "Column4";
            this.Column4.Width = 175;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TelefonSluzbowy";
            this.Column5.HeaderText = "Telefon służbowy";
            this.Column5.MinimumWidth = 9;
            this.Column5.Name = "Column5";
            this.Column5.Width = 175;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "PrywatnyTelefon";
            this.Column6.HeaderText = "Prywatny telefon";
            this.Column6.MinimumWidth = 9;
            this.Column6.Name = "Column6";
            this.Column6.Width = 175;
            // 
            // PracownicyUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl33);
            this.Name = "PracownicyUserControl";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1248, 683);
            this.tabControl33.ResumeLayout(false);
            this.tabPage68.ResumeLayout(false);
            this.tabPage68.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPracownicy)).EndInit();
            this.toolStrip16.ResumeLayout(false);
            this.toolStrip16.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl33;
        private System.Windows.Forms.TabPage tabPage68;
        private System.Windows.Forms.DataGridView dataGridViewPracownicy;
        private System.Windows.Forms.ToolStrip toolStrip16;
        private System.Windows.Forms.ToolStripButton toolStripButtonDodajPracownika;
        private System.Windows.Forms.ToolStripButton toolStripButtonUsunPracownika;
        private System.Windows.Forms.ToolStripButton toolStripButtonModyfikujPracownika;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxUprawnienia;
        private System.Windows.Forms.ToolStripLabel toolStripLabel22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column31;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column32;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}

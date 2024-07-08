
namespace WinFormsApp90.Forms.BazaWiedzy
{
    partial class BazaWiedzyUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BazaWiedzyUserControl));
            this.tableLayoutPanelBazaWiedzy = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl8 = new System.Windows.Forms.TabControl();
            this.tabPage35 = new System.Windows.Forms.TabPage();
            this.dataGridViewBazaWiedzy = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip5 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDodajBazaWiedzy = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUsunBazaWiedzy = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonModyfikujBazaWiedzy = new System.Windows.Forms.ToolStripButton();
            this.tabControl29 = new System.Windows.Forms.TabControl();
            this.tabPage64 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxTematBazaWiedzy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxRozwiazanieBazaWiedzy = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBoxZalacznikiBazaWiedzy = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanelBazaWiedzy.SuspendLayout();
            this.tabControl8.SuspendLayout();
            this.tabPage35.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBazaWiedzy)).BeginInit();
            this.toolStrip5.SuspendLayout();
            this.tabControl29.SuspendLayout();
            this.tabPage64.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelBazaWiedzy
            // 
            this.tableLayoutPanelBazaWiedzy.ColumnCount = 2;
            this.tableLayoutPanelBazaWiedzy.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBazaWiedzy.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanelBazaWiedzy.Controls.Add(this.tabControl8, 0, 0);
            this.tableLayoutPanelBazaWiedzy.Controls.Add(this.tabControl29, 1, 0);
            this.tableLayoutPanelBazaWiedzy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBazaWiedzy.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanelBazaWiedzy.Name = "tableLayoutPanelBazaWiedzy";
            this.tableLayoutPanelBazaWiedzy.RowCount = 1;
            this.tableLayoutPanelBazaWiedzy.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBazaWiedzy.Size = new System.Drawing.Size(1237, 668);
            this.tableLayoutPanelBazaWiedzy.TabIndex = 3;
            // 
            // tabControl8
            // 
            this.tabControl8.Controls.Add(this.tabPage35);
            this.tabControl8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl8.Location = new System.Drawing.Point(3, 3);
            this.tabControl8.Name = "tabControl8";
            this.tabControl8.SelectedIndex = 0;
            this.tabControl8.Size = new System.Drawing.Size(731, 662);
            this.tabControl8.TabIndex = 4;
            // 
            // tabPage35
            // 
            this.tabPage35.Controls.Add(this.dataGridViewBazaWiedzy);
            this.tabPage35.Controls.Add(this.toolStrip5);
            this.tabPage35.Location = new System.Drawing.Point(4, 39);
            this.tabPage35.Name = "tabPage35";
            this.tabPage35.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage35.Size = new System.Drawing.Size(723, 619);
            this.tabPage35.TabIndex = 0;
            this.tabPage35.Text = "Lista bazy wiedzy";
            this.tabPage35.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBazaWiedzy
            // 
            this.dataGridViewBazaWiedzy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBazaWiedzy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewBazaWiedzy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBazaWiedzy.Location = new System.Drawing.Point(3, 55);
            this.dataGridViewBazaWiedzy.Name = "dataGridViewBazaWiedzy";
            this.dataGridViewBazaWiedzy.RowHeadersWidth = 72;
            this.dataGridViewBazaWiedzy.RowTemplate.Height = 37;
            this.dataGridViewBazaWiedzy.Size = new System.Drawing.Size(717, 561);
            this.dataGridViewBazaWiedzy.TabIndex = 14;
            this.dataGridViewBazaWiedzy.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewBazaWiedzy_CellMouseClick);
            this.dataGridViewBazaWiedzy.SelectionChanged += new System.EventHandler(this.dataGridViewBazaWiedzy_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "WiedzaId";
            this.Column1.HeaderText = "WiedzaId";
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
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column3.DataPropertyName = "Temat";
            this.Column3.HeaderText = "Temat";
            this.Column3.MinimumWidth = 9;
            this.Column3.Name = "Column3";
            this.Column3.Width = 110;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Rozwiazanie";
            this.Column4.HeaderText = "Rozwiazanie";
            this.Column4.MinimumWidth = 9;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column5.DataPropertyName = "WiedzaZdjecia";
            this.Column5.HeaderText = "Zdjęcia";
            this.Column5.MinimumWidth = 9;
            this.Column5.Name = "Column5";
            this.Column5.Width = 120;
            // 
            // toolStrip5
            // 
            this.toolStrip5.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip5.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDodajBazaWiedzy,
            this.toolStripButtonUsunBazaWiedzy,
            this.toolStripButtonModyfikujBazaWiedzy});
            this.toolStrip5.Location = new System.Drawing.Point(3, 3);
            this.toolStrip5.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStrip5.Name = "toolStrip5";
            this.toolStrip5.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip5.Size = new System.Drawing.Size(717, 52);
            this.toolStrip5.TabIndex = 13;
            this.toolStrip5.Text = "toolStrip5";
            // 
            // toolStripButtonDodajBazaWiedzy
            // 
            this.toolStripButtonDodajBazaWiedzy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDodajBazaWiedzy.Image")));
            this.toolStripButtonDodajBazaWiedzy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDodajBazaWiedzy.Name = "toolStripButtonDodajBazaWiedzy";
            this.toolStripButtonDodajBazaWiedzy.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.toolStripButtonDodajBazaWiedzy.Size = new System.Drawing.Size(100, 46);
            this.toolStripButtonDodajBazaWiedzy.Text = "Dodaj";
            this.toolStripButtonDodajBazaWiedzy.Click += new System.EventHandler(this.toolStripButtonDodajBazaWiedzy_Click);
            // 
            // toolStripButtonUsunBazaWiedzy
            // 
            this.toolStripButtonUsunBazaWiedzy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUsunBazaWiedzy.Image")));
            this.toolStripButtonUsunBazaWiedzy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUsunBazaWiedzy.Name = "toolStripButtonUsunBazaWiedzy";
            this.toolStripButtonUsunBazaWiedzy.Size = new System.Drawing.Size(92, 46);
            this.toolStripButtonUsunBazaWiedzy.Text = "Usuń";
            this.toolStripButtonUsunBazaWiedzy.Click += new System.EventHandler(this.toolStripButtonUsunBazaWiedzy_Click);
            // 
            // toolStripButtonModyfikujBazaWiedzy
            // 
            this.toolStripButtonModyfikujBazaWiedzy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonModyfikujBazaWiedzy.Image")));
            this.toolStripButtonModyfikujBazaWiedzy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonModyfikujBazaWiedzy.Name = "toolStripButtonModyfikujBazaWiedzy";
            this.toolStripButtonModyfikujBazaWiedzy.Size = new System.Drawing.Size(137, 46);
            this.toolStripButtonModyfikujBazaWiedzy.Text = "Modyfikuj";
            this.toolStripButtonModyfikujBazaWiedzy.Click += new System.EventHandler(this.toolStripButtonModyfikujBazaWiedzy_Click);
            // 
            // tabControl29
            // 
            this.tabControl29.Controls.Add(this.tabPage64);
            this.tabControl29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl29.Location = new System.Drawing.Point(740, 3);
            this.tabControl29.Name = "tabControl29";
            this.tabControl29.SelectedIndex = 0;
            this.tabControl29.Size = new System.Drawing.Size(494, 662);
            this.tabControl29.TabIndex = 0;
            // 
            // tabPage64
            // 
            this.tabPage64.AutoScroll = true;
            this.tabPage64.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage64.Controls.Add(this.tableLayoutPanel3);
            this.tabPage64.Location = new System.Drawing.Point(4, 39);
            this.tabPage64.Name = "tabPage64";
            this.tabPage64.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage64.Size = new System.Drawing.Size(486, 619);
            this.tabPage64.TabIndex = 0;
            this.tabPage64.Text = "Szczegóły";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(480, 613);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxTematBazaWiedzy);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 144);
            this.panel1.TabIndex = 0;
            // 
            // textBoxTematBazaWiedzy
            // 
            this.textBoxTematBazaWiedzy.Location = new System.Drawing.Point(22, 64);
            this.textBoxTematBazaWiedzy.Name = "textBoxTematBazaWiedzy";
            this.textBoxTematBazaWiedzy.Size = new System.Drawing.Size(427, 35);
            this.textBoxTematBazaWiedzy.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rozwiązanie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Temat";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxRozwiazanieBazaWiedzy);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 257);
            this.panel2.TabIndex = 0;
            // 
            // textBoxRozwiazanieBazaWiedzy
            // 
            this.textBoxRozwiazanieBazaWiedzy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxRozwiazanieBazaWiedzy.Location = new System.Drawing.Point(22, 3);
            this.textBoxRozwiazanieBazaWiedzy.Multiline = true;
            this.textBoxRozwiazanieBazaWiedzy.Name = "textBoxRozwiazanieBazaWiedzy";
            this.textBoxRozwiazanieBazaWiedzy.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRozwiazanieBazaWiedzy.Size = new System.Drawing.Size(427, 251);
            this.textBoxRozwiazanieBazaWiedzy.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listBoxZalacznikiBazaWiedzy);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 416);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(474, 194);
            this.panel3.TabIndex = 1;
            // 
            // listBoxZalacznikiBazaWiedzy
            // 
            this.listBoxZalacznikiBazaWiedzy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxZalacznikiBazaWiedzy.FormattingEnabled = true;
            this.listBoxZalacznikiBazaWiedzy.ItemHeight = 30;
            this.listBoxZalacznikiBazaWiedzy.Location = new System.Drawing.Point(22, 39);
            this.listBoxZalacznikiBazaWiedzy.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxZalacznikiBazaWiedzy.Name = "listBoxZalacznikiBazaWiedzy";
            this.listBoxZalacznikiBazaWiedzy.ScrollAlwaysVisible = true;
            this.listBoxZalacznikiBazaWiedzy.Size = new System.Drawing.Size(427, 124);
            this.listBoxZalacznikiBazaWiedzy.TabIndex = 2;
            this.listBoxZalacznikiBazaWiedzy.DoubleClick += new System.EventHandler(this.listBoxZalacznikiBazaWiedzy_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pliki";
            // 
            // BazaWiedzyUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelBazaWiedzy);
            this.Name = "BazaWiedzyUserControl";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1277, 708);
            this.tableLayoutPanelBazaWiedzy.ResumeLayout(false);
            this.tabControl8.ResumeLayout(false);
            this.tabPage35.ResumeLayout(false);
            this.tabPage35.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBazaWiedzy)).EndInit();
            this.toolStrip5.ResumeLayout(false);
            this.toolStrip5.PerformLayout();
            this.tabControl29.ResumeLayout(false);
            this.tabPage64.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBazaWiedzy;
        private System.Windows.Forms.TabControl tabControl8;
        private System.Windows.Forms.TabPage tabPage35;
        private System.Windows.Forms.ToolStrip toolStrip5;
        private System.Windows.Forms.ToolStripButton toolStripButtonDodajBazaWiedzy;
        private System.Windows.Forms.ToolStripButton toolStripButtonUsunBazaWiedzy;
        private System.Windows.Forms.ToolStripButton toolStripButtonModyfikujBazaWiedzy;
        private System.Windows.Forms.TabControl tabControl29;
        private System.Windows.Forms.TabPage tabPage64;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxRozwiazanieBazaWiedzy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listBoxZalacznikiBazaWiedzy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxTematBazaWiedzy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewBazaWiedzy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

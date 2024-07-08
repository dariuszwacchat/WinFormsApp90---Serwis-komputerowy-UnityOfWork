
namespace WinFormsApp90.Forms.Preferencje.LicencjaWolna
{
    partial class LicencjeWolneUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicencjeWolneUserControl));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewWolneLicencje = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDodaj = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUsun = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonModyfikuj = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWolneLicencje)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(1348, 670);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewWolneLicencje);
            this.tabPage1.Controls.Add(this.toolStrip2);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1340, 627);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista wolnych licencji";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewWolneLicencje
            // 
            this.dataGridViewWolneLicencje.AllowUserToAddRows = false;
            this.dataGridViewWolneLicencje.AllowUserToDeleteRows = false;
            this.dataGridViewWolneLicencje.AllowUserToOrderColumns = true;
            this.dataGridViewWolneLicencje.AllowUserToResizeColumns = false;
            this.dataGridViewWolneLicencje.AllowUserToResizeRows = false;
            this.dataGridViewWolneLicencje.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWolneLicencje.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewWolneLicencje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewWolneLicencje.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewWolneLicencje.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewWolneLicencje.ColumnHeadersHeight = 40;
            this.dataGridViewWolneLicencje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewWolneLicencje.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewWolneLicencje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewWolneLicencje.EnableHeadersVisualStyles = false;
            this.dataGridViewWolneLicencje.Location = new System.Drawing.Point(3, 55);
            this.dataGridViewWolneLicencje.MultiSelect = false;
            this.dataGridViewWolneLicencje.Name = "dataGridViewWolneLicencje";
            this.dataGridViewWolneLicencje.ReadOnly = true;
            this.dataGridViewWolneLicencje.RowHeadersVisible = false;
            this.dataGridViewWolneLicencje.RowHeadersWidth = 72;
            this.dataGridViewWolneLicencje.RowTemplate.Height = 37;
            this.dataGridViewWolneLicencje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewWolneLicencje.Size = new System.Drawing.Size(1334, 569);
            this.dataGridViewWolneLicencje.TabIndex = 10;
            this.dataGridViewWolneLicencje.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewWolneLicencje_CellMouseClick);
            this.dataGridViewWolneLicencje.SelectionChanged += new System.EventHandler(this.dataGridViewWolneLicencje_SelectionChanged);
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDodaj,
            this.toolStripButtonUsun,
            this.toolStripButtonModyfikuj,
            this.toolStripButton1});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip2.Size = new System.Drawing.Size(1334, 52);
            this.toolStrip2.TabIndex = 9;
            this.toolStrip2.Text = "toolStrip2";
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
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(120, 46);
            this.toolStripButton1.Text = "Przypisz";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // LicencjeWolneUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "LicencjeWolneUserControl";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1388, 710);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWolneLicencje)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButtonDodaj;
        private System.Windows.Forms.ToolStripButton toolStripButtonUsun;
        private System.Windows.Forms.ToolStripButton toolStripButtonModyfikuj;
        private System.Windows.Forms.DataGridView dataGridViewWolneLicencje;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

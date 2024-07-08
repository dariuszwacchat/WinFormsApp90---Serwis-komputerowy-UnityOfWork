
namespace WinFormsApp90.Forms.Preferencje.RodzajeSprzetow
{
    partial class RodzajeSprzetuUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RodzajeSprzetuUserControl));
            this.tabControl7 = new System.Windows.Forms.TabControl();
            this.tabPage27 = new System.Windows.Forms.TabPage();
            this.dataGridViewRodzajeUrzadzen = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDodajFirma = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUsunFirma = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonModyfikujFirma = new System.Windows.Forms.ToolStripButton();
            this.tabControl7.SuspendLayout();
            this.tabPage27.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRodzajeUrzadzen)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl7
            // 
            this.tabControl7.Controls.Add(this.tabPage27);
            this.tabControl7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl7.Location = new System.Drawing.Point(20, 20);
            this.tabControl7.Name = "tabControl7";
            this.tabControl7.SelectedIndex = 0;
            this.tabControl7.Size = new System.Drawing.Size(1092, 625);
            this.tabControl7.TabIndex = 2;
            // 
            // tabPage27
            // 
            this.tabPage27.Controls.Add(this.dataGridViewRodzajeUrzadzen);
            this.tabPage27.Controls.Add(this.toolStrip2);
            this.tabPage27.Location = new System.Drawing.Point(4, 39);
            this.tabPage27.Name = "tabPage27";
            this.tabPage27.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage27.Size = new System.Drawing.Size(1084, 582);
            this.tabPage27.TabIndex = 0;
            this.tabPage27.Text = "Lista rodzajów urządzeń";
            this.tabPage27.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRodzajeUrzadzen
            // 
            this.dataGridViewRodzajeUrzadzen.AllowUserToAddRows = false;
            this.dataGridViewRodzajeUrzadzen.AllowUserToDeleteRows = false;
            this.dataGridViewRodzajeUrzadzen.AllowUserToResizeColumns = false;
            this.dataGridViewRodzajeUrzadzen.AllowUserToResizeRows = false;
            this.dataGridViewRodzajeUrzadzen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRodzajeUrzadzen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRodzajeUrzadzen.Location = new System.Drawing.Point(3, 55);
            this.dataGridViewRodzajeUrzadzen.Name = "dataGridViewRodzajeUrzadzen";
            this.dataGridViewRodzajeUrzadzen.RowHeadersWidth = 72;
            this.dataGridViewRodzajeUrzadzen.RowTemplate.Height = 37;
            this.dataGridViewRodzajeUrzadzen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRodzajeUrzadzen.Size = new System.Drawing.Size(1078, 524);
            this.dataGridViewRodzajeUrzadzen.TabIndex = 6;
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDodajFirma,
            this.toolStripButtonUsunFirma,
            this.toolStripButtonModyfikujFirma});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip2.Size = new System.Drawing.Size(1078, 52);
            this.toolStrip2.TabIndex = 7;
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
            // 
            // toolStripButtonUsunFirma
            // 
            this.toolStripButtonUsunFirma.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUsunFirma.Image")));
            this.toolStripButtonUsunFirma.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUsunFirma.Name = "toolStripButtonUsunFirma";
            this.toolStripButtonUsunFirma.Size = new System.Drawing.Size(92, 46);
            this.toolStripButtonUsunFirma.Text = "Usuń";
            // 
            // toolStripButtonModyfikujFirma
            // 
            this.toolStripButtonModyfikujFirma.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonModyfikujFirma.Image")));
            this.toolStripButtonModyfikujFirma.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonModyfikujFirma.Name = "toolStripButtonModyfikujFirma";
            this.toolStripButtonModyfikujFirma.Size = new System.Drawing.Size(137, 46);
            this.toolStripButtonModyfikujFirma.Text = "Modyfikuj";
            // 
            // RodzajeSprzetuUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl7);
            this.Name = "RodzajeSprzetuUserControl";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1132, 665);
            this.tabControl7.ResumeLayout(false);
            this.tabPage27.ResumeLayout(false);
            this.tabPage27.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRodzajeUrzadzen)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl7;
        private System.Windows.Forms.TabPage tabPage27;
        private System.Windows.Forms.DataGridView dataGridViewRodzajeUrzadzen;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButtonDodajFirma;
        private System.Windows.Forms.ToolStripButton toolStripButtonUsunFirma;
        private System.Windows.Forms.ToolStripButton toolStripButtonModyfikujFirma;
    }
}

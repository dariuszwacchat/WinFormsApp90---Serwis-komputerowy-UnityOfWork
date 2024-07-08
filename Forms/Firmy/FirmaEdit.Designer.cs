
namespace WinFormsApp90.Forms.Firmy
{
    partial class FirmaEdit
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

        #region Windows BaseForm Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxUwagiFirma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPelnaNazwa = new System.Windows.Forms.TextBox();
            this.textBoxNIP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxSkroconaNazwa = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.Controls.Add(this.textBoxUwagiFirma);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.textBoxPelnaNazwa);
            this.panel6.Controls.Add(this.textBoxNIP);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.textBoxAdres);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.textBoxSkroconaNazwa);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 100);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1510, 525);
            this.panel6.TabIndex = 123;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1510, 5);
            this.panel3.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 38);
            this.label2.TabIndex = 87;
            this.label2.Text = "Dodawanie nowej firmy";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1510, 100);
            this.panel1.TabIndex = 121;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1510, 5);
            this.panel5.TabIndex = 108;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(230, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 52);
            this.button2.TabIndex = 93;
            this.button2.Text = "Zamknij";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(39, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 52);
            this.button1.TabIndex = 94;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1065, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(445, 95);
            this.panel4.TabIndex = 107;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 625);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1510, 100);
            this.panel2.TabIndex = 122;
            // 
            // textBoxUwagiFirma
            // 
            this.textBoxUwagiFirma.Location = new System.Drawing.Point(350, 322);
            this.textBoxUwagiFirma.Multiline = true;
            this.textBoxUwagiFirma.Name = "textBoxUwagiFirma";
            this.textBoxUwagiFirma.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxUwagiFirma.Size = new System.Drawing.Size(831, 156);
            this.textBoxUwagiFirma.TabIndex = 172;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 30);
            this.label1.TabIndex = 171;
            this.label1.Text = "Uwagi";
            // 
            // textBoxPelnaNazwa
            // 
            this.textBoxPelnaNazwa.Location = new System.Drawing.Point(350, 37);
            this.textBoxPelnaNazwa.Multiline = true;
            this.textBoxPelnaNazwa.Name = "textBoxPelnaNazwa";
            this.textBoxPelnaNazwa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPelnaNazwa.Size = new System.Drawing.Size(831, 156);
            this.textBoxPelnaNazwa.TabIndex = 170;
            // 
            // textBoxNIP
            // 
            this.textBoxNIP.Location = new System.Drawing.Point(350, 281);
            this.textBoxNIP.Name = "textBoxNIP";
            this.textBoxNIP.Size = new System.Drawing.Size(831, 35);
            this.textBoxNIP.TabIndex = 169;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 290);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 30);
            this.label12.TabIndex = 166;
            this.label12.Text = "NIP";
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.Location = new System.Drawing.Point(350, 240);
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(831, 35);
            this.textBoxAdres.TabIndex = 167;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(49, 249);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 30);
            this.label14.TabIndex = 165;
            this.label14.Text = "Adres";
            // 
            // textBoxSkroconaNazwa
            // 
            this.textBoxSkroconaNazwa.Location = new System.Drawing.Point(350, 199);
            this.textBoxSkroconaNazwa.Name = "textBoxSkroconaNazwa";
            this.textBoxSkroconaNazwa.Size = new System.Drawing.Size(831, 35);
            this.textBoxSkroconaNazwa.TabIndex = 168;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(49, 208);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(216, 30);
            this.label15.TabIndex = 163;
            this.label15.Text = "Skrócona nazwa firmy";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(49, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(182, 30);
            this.label16.TabIndex = 164;
            this.label16.Text = "Pełna nazwa firmy";
            // 
            // FirmaEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 725);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FirmaEdit";
            this.Text = "s";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FirmaEdit_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxUwagiFirma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPelnaNazwa;
        private System.Windows.Forms.TextBox textBoxNIP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxSkroconaNazwa;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}
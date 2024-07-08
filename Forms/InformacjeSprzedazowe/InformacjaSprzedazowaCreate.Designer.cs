
namespace WinFormsApp90.Forms.InformacjeSprzedazowe
{
    partial class InformacjaSprzedazowaCreate
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxSprzetItems = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.listBoxZalaczniki = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label140 = new System.Windows.Forms.Label();
            this.textBoxUwagi = new System.Windows.Forms.TextBox();
            this.label145 = new System.Windows.Forms.Label();
            this.textBoxNazwaProduktu = new System.Windows.Forms.TextBox();
            this.textBoxCena = new System.Windows.Forms.TextBox();
            this.label147 = new System.Windows.Forms.Label();
            this.label148 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1526, 100);
            this.panel3.TabIndex = 146;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 95);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1526, 5);
            this.panel6.TabIndex = 88;
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1526, 5);
            this.panel5.TabIndex = 108;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1081, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(445, 95);
            this.panel4.TabIndex = 107;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 635);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1526, 100);
            this.panel2.TabIndex = 145;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.comboBoxSprzetItems);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.buttonUsun);
            this.panel1.Controls.Add(this.buttonDodaj);
            this.panel1.Controls.Add(this.listBoxZalaczniki);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label140);
            this.panel1.Controls.Add(this.textBoxUwagi);
            this.panel1.Controls.Add(this.label145);
            this.panel1.Controls.Add(this.textBoxNazwaProduktu);
            this.panel1.Controls.Add(this.textBoxCena);
            this.panel1.Controls.Add(this.label147);
            this.panel1.Controls.Add(this.label148);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1526, 535);
            this.panel1.TabIndex = 147;
            // 
            // comboBoxSprzetItems
            // 
            this.comboBoxSprzetItems.FormattingEnabled = true;
            this.comboBoxSprzetItems.Location = new System.Drawing.Point(371, 561);
            this.comboBoxSprzetItems.Name = "comboBoxSprzetItems";
            this.comboBoxSprzetItems.Size = new System.Drawing.Size(828, 38);
            this.comboBoxSprzetItems.TabIndex = 179;
            this.comboBoxSprzetItems.SelectedIndexChanged += new System.EventHandler(this.comboBoxSprzet_SelectedIndexChanged);
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(16, 488);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(13, 193);
            this.panel7.TabIndex = 177;
            // 
            // buttonUsun
            // 
            this.buttonUsun.Location = new System.Drawing.Point(1068, 474);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(131, 40);
            this.buttonUsun.TabIndex = 176;
            this.buttonUsun.Text = "Usuń";
            this.buttonUsun.UseVisualStyleBackColor = true;
            this.buttonUsun.Click += new System.EventHandler(this.buttonUsun_Click);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(930, 474);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(131, 40);
            this.buttonDodaj.TabIndex = 175;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // listBoxZalaczniki
            // 
            this.listBoxZalaczniki.FormattingEnabled = true;
            this.listBoxZalaczniki.ItemHeight = 30;
            this.listBoxZalaczniki.Location = new System.Drawing.Point(371, 312);
            this.listBoxZalaczniki.Name = "listBoxZalaczniki";
            this.listBoxZalaczniki.ScrollAlwaysVisible = true;
            this.listBoxZalaczniki.Size = new System.Drawing.Size(828, 154);
            this.listBoxZalaczniki.TabIndex = 174;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 561);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 30);
            this.label1.TabIndex = 173;
            this.label1.Text = "Rodzaj sprzętu";
            // 
            // label140
            // 
            this.label140.AutoSize = true;
            this.label140.Location = new System.Drawing.Point(50, 312);
            this.label140.Name = "label140";
            this.label140.Size = new System.Drawing.Size(263, 30);
            this.label140.TabIndex = 173;
            this.label140.Text = "Faktura zakupu / załączniki";
            // 
            // textBoxUwagi
            // 
            this.textBoxUwagi.Location = new System.Drawing.Point(371, 132);
            this.textBoxUwagi.Multiline = true;
            this.textBoxUwagi.Name = "textBoxUwagi";
            this.textBoxUwagi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxUwagi.Size = new System.Drawing.Size(828, 174);
            this.textBoxUwagi.TabIndex = 169;
            // 
            // label145
            // 
            this.label145.AutoSize = true;
            this.label145.Location = new System.Drawing.Point(49, 135);
            this.label145.Name = "label145";
            this.label145.Size = new System.Drawing.Size(70, 30);
            this.label145.TabIndex = 168;
            this.label145.Text = "Uwagi";
            // 
            // textBoxNazwaProduktu
            // 
            this.textBoxNazwaProduktu.Location = new System.Drawing.Point(371, 50);
            this.textBoxNazwaProduktu.Name = "textBoxNazwaProduktu";
            this.textBoxNazwaProduktu.Size = new System.Drawing.Size(828, 35);
            this.textBoxNazwaProduktu.TabIndex = 166;
            // 
            // textBoxCena
            // 
            this.textBoxCena.Location = new System.Drawing.Point(371, 91);
            this.textBoxCena.Name = "textBoxCena";
            this.textBoxCena.Size = new System.Drawing.Size(828, 35);
            this.textBoxCena.TabIndex = 167;
            // 
            // label147
            // 
            this.label147.AutoSize = true;
            this.label147.Location = new System.Drawing.Point(49, 91);
            this.label147.Name = "label147";
            this.label147.Size = new System.Drawing.Size(60, 30);
            this.label147.TabIndex = 165;
            this.label147.Text = "Cena";
            // 
            // label148
            // 
            this.label148.AutoSize = true;
            this.label148.Location = new System.Drawing.Point(49, 50);
            this.label148.Name = "label148";
            this.label148.Size = new System.Drawing.Size(166, 30);
            this.label148.TabIndex = 164;
            this.label148.Text = "Nazwa produktu";
            // 
            // InformacjaSprzedazowaCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 735);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "InformacjaSprzedazowaCreate";
            this.Text = "InformacjaSprzedazowaCreate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InformacjaSprzedazowaCreate_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button buttonUsun;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.ListBox listBoxZalaczniki;
        private System.Windows.Forms.Label label140;
        private System.Windows.Forms.TextBox textBoxUwagi;
        private System.Windows.Forms.Label label145;
        private System.Windows.Forms.TextBox textBoxNazwaProduktu;
        private System.Windows.Forms.TextBox textBoxCena;
        private System.Windows.Forms.Label label147;
        private System.Windows.Forms.Label label148;
        private System.Windows.Forms.ComboBox comboBoxSprzetItems;
        private System.Windows.Forms.Label label1;
    }
}